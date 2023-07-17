using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Configuration;

namespace Aida.Samples.WebhooksReceiverConsole.HostedServices
{
    /// <summary>
    /// Hosted service that processes messages from AIDAMessageCollection 
    /// </summary>
    public class MessagesBackgroundWorker : IHostedService
    {
        private readonly MessageCollection                 _messages;
        private readonly JsonSerializerOptions             _jsonSerializerOptions;
        private readonly IConfiguration                    _configuration;
        private readonly IntegrationApi                    _api;
        private readonly ILogger<MessagesBackgroundWorker> _logger;

        public MessagesBackgroundWorker(
            IConfiguration configuration,
            MessageCollection messages,
            IntegrationApi api,
            ILogger<MessagesBackgroundWorker> logger)
        {
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            };
            _configuration = configuration;
            _api = api;
            _messages = messages;
            _logger = logger;
        }

        /// <summary>
        /// Starts an async task 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken cancellationToken)
        {
            _ = Task.Run(() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        var message = _messages.TakeMessage(cancellationToken);
                        _logger.LogInformation("Message {MessageType}", message.MessageType);

                        if (message.JobId is not null)
                        {
                            _logger.LogInformation("Job id: {JobId}, status: {Status}, document produced: {DocumentProduced}", message.JobId, message.JobStatus,
                                message.DocumentProduced);
                        }

                        switch (message)
                        {
                            case WorkflowSchedulerStoppedMessage stopped:
                                _logger.LogWarning("Workflow Scheduler stopped. ErrorCode = {ErrorCode}", stopped.ErrorCode);
                                break;

                            case WorkflowSchedulerStartedMessage:
                                _logger.LogInformation("Workflow Scheduler started");
                                break;

                            // These are fire and forget for AIDA. 
                            case WorkflowCancelledMessage:
                                _logger.LogWarning("Job {JobId} cancelled", message.JobId);
                                break;

                            case WorkflowCompletedMessage:
                                _logger.LogInformation("Job {JobId} completed", message.JobId);
                                break;

                            case WorkflowFaultedMessage fault:
                                _logger.LogWarning("Job {JobId} faulted. JobStatus: {JobStatus}, ErrorCode: {ErrorCode}", fault.JobId, fault.JobStatus, fault.ErrorCode);
                                break;

                            // These are notifications that indicate that the workflow was suspended
                            // The workflow was suspended because AIDA was not able to get the card 
                            // from the feeder or it was about to move a card in the engraving position but open interlocks where found.
                            case WorkflowSchedulerProcessSuspendedMessage suspended:
                                switch (suspended.ErrorCode)
                                {
                                    case JobErrorCodes.FeederEmpty:
                                        // Intentionally block until we receive user input 
                                        _logger.LogWarning("\n\nFeeder empty\nLoad the input feeder with cards and press the 'Resume' button");
                                        break;

                                    case JobErrorCodes.OpenInterlock:
                                        _logger.LogWarning("\n\n Mark activity suspended.Open interlocks detected." +
                                                           "Please verify all interlocks are properly locked, then click the 'Resume'");
                                        break;
                                }

                                break;

                            // These events require the receiving application to invoke SignalExternalProcessCompleted.
                            // The card is positioned in the SmartCard reader. AIDA is waiting the external application
                            // to signal the completion (and outcome) of the operation.
                            case EncoderLoadedMessage encoderLoaded:
                                // Mock the chip personalization process. 
                                _ = MockChipEncodingPersonalization(encoderLoaded);
                                break;


                            // AIDA executed an OCR operation successfully. The notification contains the list of results
                            // obtained from the OCR reading, it now expects the receiving application to validate the 
                            // results and signal the outcome of the validation 
                            case OcrExecutedMessage ocrMessage:
                                _ = MockOcrValidation(ocrMessage);
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e, "Failed to process AIDA notification");
                    }
                }

                return Task.FromResult(Task.CompletedTask);
            }, cancellationToken);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        /// <summary>
        /// </summary>
        /// <param name="message"></param>
        private async Task MockOcrValidation(OcrExecutedMessage message)
        {
            try
            {
                var responseMessage = new ExternalProcessCompletedMessage
                {
                    // We tell AIDA chip personalization completed without error
                    Outcome = ExternalProcessOutcome.Completed,
                    // This is the WorkflowInstanceId we received in the webhook notification
                    WorkflowInstanceId = message.WorkflowInstanceId,
                };

                _logger.LogInformation("Ocr Validation completed {Validation}", JsonSerializer.Serialize(message, _jsonSerializerOptions));
                // tell AIDA to dispatch the completion signal and resume 
                await _api.SignalExternalProcessCompletedAsync(
                    // waitForCompletion = false tells aida to return immediately the
                    // HTTP response without waiting the workflow to finish 
                    waitForCompletion: false,
                    // The response message
                    externalProcessCompletedMessage: responseMessage).ConfigureAwait(false);

                _logger.LogInformation("Message published. Outcome = {Outcome}, WorkflowId = {WorkflowId}, {Message}",
                    responseMessage.Outcome,
                    responseMessage.WorkflowInstanceId,
                    JsonSerializer.Serialize(message, _jsonSerializerOptions));
            }
            catch (Exception e)
            {
                _logger.LogError(e, "OCR Validation Resume Failed");
            }
        }

        /// <summary>
        /// Mock chip personalization by waiting for a predefined amount of time before sending the completed notification to AIDA
        /// </summary>
        /// <param name="message"></param>
        private Task MockChipEncodingPersonalization(WorkflowMessage message)
        {
            _logger.LogInformation("Running chip personalization for job: {JobId}", message.JobId);
            _ = Task.Run(() =>
            {
                Task.Delay(5_000).ConfigureAwait(false).GetAwaiter().GetResult();

                var errorRate = _configuration.GetValue("EncodingErrorRate", 0);
                var rnd       = new Random();
                var value     = rnd.Next(0, 100);
                var outcome   = value < errorRate ? ExternalProcessOutcome.Faulted : ExternalProcessOutcome.Completed;

                try
                {
                    var responseMessage = new ExternalProcessCompletedMessage
                    {
                        // We tell AIDA chip personalization completed without error
                        Outcome = outcome,
                        // This is the WorkflowInstanceId we received in the webhook notification
                        WorkflowInstanceId = message.WorkflowInstanceId,
                    };

                    _logger.LogInformation("Chip personalization completed. Sending completion signal to AIDA {BasePath} {Message}",
                        _api.GetBasePath(),
                        JsonSerializer.Serialize(responseMessage, _jsonSerializerOptions));

                    // tell AIDA to dispatch the completion signal and resume 
                    _api.SignalExternalProcessCompletedAsync(
                        // waitForCompletion = false tells aida to return immediately the HTTP response without waiting the workflow
                        // to finish 
                        waitForCompletion: false,
                        // The response message
                        externalProcessCompletedMessage: responseMessage).ConfigureAwait(false).GetAwaiter().GetResult();
                }
                catch
                {
                }
            });
            return Task.CompletedTask;
        }
    }
}