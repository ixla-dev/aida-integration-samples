using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
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
        private readonly ILogger<MessagesBackgroundWorker> _logger;
        private readonly MessageCollection                 _messages;
        private readonly ApiClientFactory                  _clientFactory;
        private readonly IConfiguration                    _configuration;
        private readonly JsonSerializerOptions             _jsonSerializerOptions;

        public MessagesBackgroundWorker(
            IConfiguration configuration,
            MessageCollection messages,
            ApiClientFactory clientFactory,
            ILogger<MessagesBackgroundWorker> logger)
        {
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            };
            _logger = logger;
            _messages = messages;
            _configuration = configuration;
            _clientFactory = clientFactory;
        }

        /// <summary>
        /// Starts an async task 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken stoppingToken)
        {
            _ = Task.Run(() =>
            {
                var cts               = new CancellationTokenSource();
                var cancellationToken = cts.Token;
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        var aidaMessage  = _messages.TakeMessage(cancellationToken);
                        var eventMessage = aidaMessage.Message;

                        if (_configuration.GetValue("LogWebhooksPayload", false))
                            _logger.LogInformation("Message {MessageType}", eventMessage.MessageType);

                        if (eventMessage.JobId is not null)
                            _logger.LogInformation(
                                "CorrelationId: {CorrelationId} job id: {JobId}, event: {WorkflowEvent} status: {Status}, error code: {ErrorCode}, document produced: {DocumentProduced}",
                                eventMessage.CorrelationId,
                                eventMessage.JobId,
                                eventMessage.MessageType,
                                eventMessage.JobStatus,
                                eventMessage.ErrorCode,
                                eventMessage.DocumentProduced);

                        var ipAddress = aidaMessage.IpAddress;
                        var client    = _clientFactory(ipAddress);

                        _logger.LogInformation("Processing message {AidaMessageType}", eventMessage.GetType().Name);

                        switch (eventMessage)
                        {
                            case WorkflowSchedulerStoppedMessage stopped:
                                cts.Cancel();
                                _logger.LogWarning("Workflow Scheduler stopped. Error code = {ErrorCode}, stop reason = {StopReason}, source job id = {SourceJobId}",
                                    stopped.ErrorCode,
                                    stopped.StopReason,
                                    stopped.SourceJobInstanceId);
                                break;

                            case WorkflowSchedulerStartedMessage started:
                                _logger.LogInformation("Workflow Scheduler started");
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
                                        _logger.LogWarning("\n\n Open interlocks detected. Please verify all interlocks are properly locked, then click the 'Resume'");
                                        break;
                                }

                                break;
                            // These are fire and forget for AIDA. 
                            case WorkflowCancelledMessage:
                                // _logger.LogWarning("Job {JobId} cancelled", eventMessage.JobId);
                                break;

                            case WorkflowCompletedMessage:
                                // _logger.LogInformation("Job {JobId} completed", eventMessage.JobId);
                                break;

                            case WorkflowFaultedMessage fault:
                                // _logger.LogWarning("Job {JobId} faulted. JobStatus: {JobStatus}, ErrorCode: {ErrorCode}", fault.JobId, fault.JobStatus, fault.ErrorCode);
                                break;

                            // These events require the receiving application to invoke SignalExternalProcessCompleted.
                            // The card is positioned in the SmartCard reader. AIDA is waiting the external application
                            // to signal the completion (and outcome) of the operation.
                            case EncoderLoadedMessage encoderLoaded:
                                // Mock the chip personalization process. 
                                _ = Task.Run(async () =>
                                {
                                    try
                                    {
                                        _logger.LogInformation("Mocking chip encoding for job {JobId}", encoderLoaded.JobId);
                                        await MockChipEncodingPersonalization(encoderLoaded, client, cancellationToken);
                                    }
                                    catch (Exception e)
                                    {
                                        _logger.LogError(e, e.Message);
                                    }
                                });
                                break;

                            // AIDA executed an OCR operation successfully. The notification contains the list of results
                            // obtained from the OCR reading, it now expects the receiving application to validate the 
                            // results and signal the outcome of the validation 
                            case OcrExecutedMessage ocrMessage:
                                _ = MockOcrValidation(ocrMessage, client, cancellationToken);
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e, "Failed to process AIDA notification");
                    }
                }

                return Task.FromResult(Task.CompletedTask);
            }, cancellationToken: stoppingToken);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        /// <summary>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="api"></param>
        /// <param name="cancellationToken"></param>
        private async Task MockOcrValidation(OcrExecutedMessage message, IntegrationApi api, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) return;
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
                await api.SignalExternalProcessCompletedAsync(
                        // waitForCompletion = false tells aida to return immediately the
                        // HTTP response without waiting the workflow to finish 
                        waitForCompletion: false,
                        // The response message
                        externalProcessCompletedMessage: responseMessage,
                        cancellationToken)
                    .ConfigureAwait(false);

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
        /// <param name="api"></param>
        /// <param name="cancellationToken"></param>
        private async Task MockChipEncodingPersonalization(WorkflowMessage message, IntegrationApi api, CancellationToken cancellationToken)
        {
            // _logger.LogInformation("Running chip personalization for job: {JobId}", message.JobId);
            if (cancellationToken.IsCancellationRequested) return;

            var errorRate = _configuration.GetValue("EncodingErrorRate", 0);
            var rnd       = new Random();
            var value     = rnd.Next(0, 100);
            var outcome   = value < errorRate ? ExternalProcessOutcome.Faulted : ExternalProcessOutcome.Completed;

            try
            {
                var duration = TimeSpan.Parse(_configuration.GetValue<string>("MockEncodingDuration"));
                _logger.LogInformation("Mocking chip encoding, jobId = {JobId}, duration = {Duration}", message.JobId, duration);
                await Task.Delay(duration, cancellationToken).ConfigureAwait(false);
                var responseMessage = new ExternalProcessCompletedMessage
                {
                    // We tell AIDA chip personalization completed without error
                    Outcome = outcome,
                    // This is the WorkflowInstanceId we received in the webhook notification
                    WorkflowInstanceId = message.WorkflowInstanceId
                };

                _logger.LogInformation("CorrelationId: {CorrelationId}, job id: {JobId}, Chip Perso: {OperationOutcome}", message.CorrelationId, message.JobId, outcome);

                // tell AIDA to dispatch the completion signal and resume 
                await api.SignalExternalProcessCompletedAsync(
                        // waitForCompletion = false tells aida to return immediately the HTTP response without waiting the workflow to finish 
                        waitForCompletion: false,
                        // The response message
                        externalProcessCompletedMessage: responseMessage,
                        cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
            }
        }
    }
}