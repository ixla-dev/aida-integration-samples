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

namespace Aida.Samples.WebhooksReceiverConsole.HostedServices
{
    /// <summary>
    /// Hosted service that processes messages from AIDAMessageCollection 
    /// </summary>
    public class MessagesBackgroundWorker : IHostedService
    {
        private readonly MessageCollection                 _messages;
        private readonly JsonSerializerOptions             _jsonSerializerOptions;
        private readonly IntegrationApi                    _api;
        private readonly ILogger<MessagesBackgroundWorker> _logger;

        public MessagesBackgroundWorker(
            MessageCollection messages,
            IntegrationApi api,
            ILogger<MessagesBackgroundWorker> logger)
        {
            _jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            };
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
            _ = Task.Run(async () =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        var message = _messages.TakeMessage(cancellationToken);
                        _logger.LogInformation("Message {MessageType}", message.MessageType);

                        if (message.JobId is not null)
                        {
                            _logger.LogInformation("Job id: {JobId}, status: {Status}", message.JobId, message.JobStatus);
                            _logger.LogInformation("Completed Tasks: {Executed}/{Total}",
                                message.PersonalizationTasks.Where(p => p.Status is PersonalizationTaskStatus.Completed).ToList().Count,
                                message.PersonalizationTasks.Count
                            );
                            _logger.LogInformation("Document Produced: {DocumentProduced}", message.DocumentProduced);
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
                                        Console.WriteLine("\n\nFeeder empty\nLoad the input feeder with cards and press the 'Resume' button");
                                        break;
                                    case JobErrorCodes.OpenInterlock:
                                        Console.WriteLine("\n\n Mark activity suspended.Open interlocks detected.Please verify all interlocks are properly locked, then click the 'Resume'");
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
                            case OcrExecutedMessage:
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        _logger.LogError(e, "Failed to process AIDA notification");
                    }
                }

                return Task.CompletedTask;
            }, cancellationToken);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Mock chip personalization by waiting for a predefined amount of time before sending the completed notification to AIDA
        /// </summary>
        /// <param name="message"></param>
        private async Task MockChipEncodingPersonalization(WorkflowMessage message)
        {
            _logger.LogInformation("Running chip personalization for job: {JobId}", message.JobId);
            await Task.Delay(3000).ConfigureAwait(false);

            _ = Task.Run(async () =>
            {
                try
                {
                    var responseMessage = new ExternalProcessCompletedMessage
                    {
                        Outcome = ExternalProcessOutcome.Completed,
                        WorkflowInstanceId = message.WorkflowInstanceId,
                    };

                    _logger.LogInformation("Chip personalization completed. Sending completion signal to AIDA {BasePath} {Message}",
                        _api.GetBasePath(), JsonSerializer.Serialize(responseMessage, _jsonSerializerOptions));

                    await _api.SignalExternalProcessCompletedAsync(
                        // tell AIDA to dispatch the completion signal and resume 
                        waitForCompletion: false,
                        externalProcessCompletedMessage: responseMessage).ConfigureAwait(false);
                }
                catch
                {
                }
            });
        }
    }
}