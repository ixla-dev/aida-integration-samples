using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Aida.Sdk.Mini.Api;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Configuration;

namespace Aida.Samples.WebhooksReceiverConsole.HostedServices
{
    public class ResultsLogger : IDisposable, IAsyncDisposable
    {
        private const    string       FILE_LOG_PATH = "./OCR_RESULT.log";
        private readonly StreamWriter _logWriter;


        public ResultsLogger() { _logWriter = File.AppendText(FILE_LOG_PATH); }
        public void Dispose() { _logWriter?.Dispose(); }
        public async ValueTask DisposeAsync()
        {
            if (_logWriter != null) await _logWriter.DisposeAsync();
        }
    }

    public class GlobalCounters : SessionCounters
    {
    }

    public class SessionCounters
    {
        public DateTime IssuanceStartTimeStamp { get; set; }
        public DateTime FirstCompletedTimestamp { get; set; }

        public TimeSpan ElapsedTimeSinceStart => DateTime.Now - IssuanceStartTimeStamp;
        public TimeSpan ElapsedTimeSinceFirstCard => DateTime.Now - FirstCompletedTimestamp;

        public int Processing { get; set; }
        public int Rejected { get; set; }
        public int Completed { get; set; }
        public int Encoding { get; set; }
        public int Processed => Completed + Rejected;
        public int StartSignals { get; set; } = 0;

        public void ProcessMessage(WorkflowMessage message)
        {
            switch (message)
            {
                case WorkflowSchedulerStartedMessage:
                    Reset();
                    IssuanceStartTimeStamp = DateTime.Now;
                    break;
                case WorkflowFaultedMessage:
                    Rejected++;
                    Processing--;
                    break;
                case WorkflowStartedMessage:
                    Processing++;
                    StartSignals++;
                    break;
                case EncoderLoadedMessage:
                    Encoding++;
                    break;
                case WorkflowCompletedMessage:
                    Completed++;
                    Processing--;
                    if (Completed == 1)
                        FirstCompletedTimestamp = DateTime.Now;
                    break;
            }
        }

        public void Reset()
        {
            Processing = 0;
            Rejected = 0;
            Completed = 0;
            Encoding = 0;
        }
    }

    /// <summary>
    /// Hosted service that processes messages from AIDAMessageCollection 
    /// </summary>
    public class MessagesBackgroundWorker(
        SessionCounters counters,
        IConfiguration configuration,
        MessageCollection messages,
        ApiClientFactory clientFactory,
        ILogger<MessagesBackgroundWorker> logger)
        : IHostedService
    {
        private readonly Random _random = new(DateTime.UtcNow.Millisecond * 1000);

        private readonly JsonSerializerOptions _jsonSerializerOptions = new()
        {
            WriteIndented = true,
            Converters = { new JsonStringEnumConverter() }
        };

        /// <summary>
        /// Starts an async task 
        /// </summary>
        /// <param name="stoppingToken"></param>
        /// <returns></returns>
        public Task StartAsync(CancellationToken stoppingToken)
        {
            _ = ProcessMessages(stoppingToken)
                .ConfigureAwait(false);
            logger.LogDebug("Message processor started");
            return Task.CompletedTask;
        }
        public async Task ProcessMessages(CancellationToken cancellationToken)
        {
            logger.LogDebug("Server started. Waiting messages...");
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var aidaMessage = messages.TakeMessage();
                    if (aidaMessage is null)
                    {
                        await Task.Delay(250, default);
                        continue;
                    }

                    var eventMessage = aidaMessage.Message;

                    counters.ProcessMessage(eventMessage);

                    if (eventMessage.JobId is null)
                    {
                        if (eventMessage.MessageType != MessageType.HealthCheck)
                            logger.LogInformation("Message {MessageType}", eventMessage.MessageType);
                    }

                    if (eventMessage.JobId is not null)
                        logger.LogInformation(
                            "MESSAGE {CorrelationId}, {JobId}, {MessageType}, {JobStatus}, {ErrorCode}, {DocumentProduced}",
                            eventMessage.CorrelationId,
                            eventMessage.JobId,
                            eventMessage.MessageType,
                            eventMessage.JobStatus,
                            eventMessage.ErrorCode,
                            eventMessage.DocumentProduced
                        );

                    var ipAddress = aidaMessage.IpAddress;
                    var client    = clientFactory(ipAddress);

                    // logger.LogInformation("Processing message {AidaMessageType}", eventMessage.GetType().Name);

                    switch (eventMessage)
                    {
                        case WorkflowSchedulerStoppedMessage stopped:
                            logger.LogWarning(
                                "Workflow Scheduler stopped. Error code = {ErrorCode}, stop reason = {StopReason}, source job id = {SourceJobId}",
                                stopped.ErrorCode,
                                stopped.StopReason,
                                stopped.SourceJobInstanceId
                            );
                            break;

                        case WorkflowSchedulerStartedMessage:
                            logger.LogInformation("Workflow Scheduler started");
                            break;
                        // These are notifications that indicate that the workflow was suspended
                        // The workflow was suspended because AIDA was not able to get the card 
                        // from the feeder, or it was about to move a card in the engraving position but open interlocks where found.
                        case WorkflowSchedulerProcessSuspendedMessage suspended:
                            switch (suspended.ErrorCode)
                            {
                                case JobErrorCodes.CardJam:
                                    break;
                                case JobErrorCodes.FeederEmpty:
                                    logger.LogWarning("\n\nFeeder empty\nLoad the input feeder with cards and press the 'Resume' button");
                                    break;
                                case JobErrorCodes.OpenInterlock:
                                    logger.LogWarning("\n\n Open interlocks detected. Please verify all interlocks are properly locked, then click the 'Resume'");
                                    break;
                            }
                            break;
                        case OcrReadBackMessage readBackMessage:
                            logger.LogInformation(
                                "CorrelationId: {CorrelationId}, JobId: {JobId},  Confidence: {Confidence}, Text: \n'{Text}'", readBackMessage.CorrelationId,
                                readBackMessage.JobId,
                                readBackMessage.Text, readBackMessage.MeanConfidence
                            );
                            _ = MockOcrReadBackValidation(readBackMessage, client);
                            break;
                        // These are fire and forget for AIDA. 
                        case WorkflowCancelledMessage: break;
                        case WorkflowCompletedMessage: break;
                        case WorkflowFaultedMessage:   break;

                        case MagneticStripeReadBackMessage readBack:
                            logger.LogInformation(
                                "MAGNETIC READ_BACK RECEIVED. \nTrack1={Track1},\nTrack2={Track2},\nTrack3={Track3}",
                                readBack.Track1Base64 is not null
                                    ? Encoding.UTF8.GetString(Convert.FromBase64String(readBack.Track1Base64))
                                    : "",
                                readBack.Track2Base64 is not null
                                    ? Encoding.UTF8.GetString(Convert.FromBase64String(readBack.Track2Base64))
                                    : "",
                                readBack.Track3Base64 is not null
                                    ? Encoding.UTF8.GetString(Convert.FromBase64String(readBack.Track3Base64))
                                    : ""
                            );
                            _ = MockMagneticReadBackValidation(readBack, client);
                            break;


                        case BarcodeReadBackMessage barcodeReadBackMessage:

                            _ = HandleBarcodeReadBackMessage(barcodeReadBackMessage, client);

                            break;

                        // These events require the receiving application to invoke SignalExternalProcessCompleted.
                        // The card is positioned in the SmartCard reader. AIDA is waiting the external application
                        // to signal the completion (and outcome) of the operation.
                        case EncoderLoadedMessage encoderLoaded:
                            // Mock the chip personalization process.
                            _ = MockChipEncodingPersonalization(encoderLoaded, client, CancellationToken.None)
                                .ConfigureAwait(false);
                            break;

                        // AIDA executed an OCR operation successfully. The notification contains the list of results
                        // obtained from the OCR reading, it now expects the receiving application to validate the 
                        // results and signal the outcome of the validation 
                        case OcrExecutedMessage ocrMessage:
                            _ = MockOcrValidation(ocrMessage, client, CancellationToken.None)
                                .ConfigureAwait(false);
                            break;
                    }
                }
                catch (Exception e)
                {
                    logger.LogError(e, "Failed to process AIDA notification");
                }
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

        public async Task HandleBarcodeReadBackMessage(BarcodeReadBackMessage message, IntegrationApi api)
        {
            var response = new ExternalProcessCompletedMessage
            {
                Outcome = ExternalProcessOutcome.Completed,
                WorkflowInstanceId = message.WorkflowInstanceId
            };
            await api.SignalExternalProcessCompletedAsync(false, response).ConfigureAwait(false);
        }

        /// <summary>
        /// </summary>
        /// <param name="readBackMessage"></param>
        /// <param name="api"></param>
        public static async Task MockOcrReadBackValidation(OcrReadBackMessage readBackMessage, IntegrationApi api)
        {
            try
            {
                var response = new ExternalProcessCompletedMessage()
                {
                    Outcome = ExternalProcessOutcome.Completed,
                    WorkflowInstanceId = readBackMessage.WorkflowInstanceId
                };
                await api.SignalExternalProcessCompletedAsync(false, response)
                    .ConfigureAwait(false);
            }
            catch
            {
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="readBack"></param>
        /// <param name="api"></param>
        public static async Task MockMagneticReadBackValidation(MagneticStripeReadBackMessage readBack, IntegrationApi api)
        {
            try
            {
                var response = new ExternalProcessCompletedMessage()
                {
                    Outcome = ExternalProcessOutcome.Completed,
                    WorkflowInstanceId = readBack.WorkflowInstanceId
                };
                await api.SignalExternalProcessCompletedAsync(false, response)
                    .ConfigureAwait(false);
            }
            catch
            {
            }
        }

        /// <summary>
        /// </summary>
        /// <param name="message"></param>
        /// <param name="api"></param>
        /// <param name="cancellationToken"></param>
        private async Task MockOcrValidation(OcrExecutedMessage message, IntegrationApi api, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested) 
                return;
            try
            {
                var shouldFail = _random.Next(0, 100) < 0;
                var outcome = shouldFail
                    ? ExternalProcessOutcome.Faulted
                    : ExternalProcessOutcome.Completed;

                var responseMessage = new ExternalProcessCompletedMessage
                {
                    // Ocr Failed
                    Outcome = outcome,
                    // This is the WorkflowInstanceId we received in the webhook notification
                    WorkflowInstanceId = message.WorkflowInstanceId,
                };

                if (message.Results.Any(r => r.OcrResult.MeanConfidence < 8.0))
                {
                    responseMessage.Outcome = ExternalProcessOutcome.Faulted;
                }
                
                logger.LogDebug("[{JobId}][{WorkflowId}] {ResultCount}", message.JobId, message.WorkflowInstanceId, message.Results.Count);
                
                foreach (var r in message.Results)
                {
                    var ocrResult = r.OcrResult;
                    if (ocrResult.MeanConfidence < 0.8)
                    {
                        logger.LogWarning("[{JobId}][{WorkflowId}] {Confidence} {Text}", message.JobId, message.WorkflowInstanceId, ocrResult.MeanConfidence, ocrResult.Text);
                    }
                    else
                    {
                        logger.LogInformation("[{JobId}][{WorkflowId}] {Confidence} {Text}", message.JobId, message.WorkflowInstanceId, ocrResult.MeanConfidence, ocrResult.Text);
                    }
                    
                }

                logger.LogDebug("Ocr Validation completed {Validation}", JsonSerializer.Serialize(message, _jsonSerializerOptions));
                // tell AIDA to dispatch the completion signal and resume 
                await api.SignalExternalProcessCompletedAsync(
                        // waitForCompletion = false tells aida to return immediately the
                        // HTTP response without waiting the workflow to finish 
                        waitForCompletion: false,
                        // The response message
                        externalProcessCompletedMessage: responseMessage,
                        cancellationToken
                    )
                    .ConfigureAwait(false);

                logger.LogDebug(
                    "Message published. Outcome = {Outcome}, WorkflowId = {WorkflowId}, {Message}",
                    responseMessage.Outcome,
                    responseMessage.WorkflowInstanceId,
                    JsonSerializer.Serialize(message, _jsonSerializerOptions)
                );
            }
            catch (Exception e)
            {
                logger.LogError(e, "OCR Validation Resume Failed");
            }
        }

        /// <summary>
        /// Mock chip personalization by waiting for a predefined amount of time before sending the completed notification to AIDA
        /// </summary>
        /// <param name="message"></param>
        /// <param name="api"></param>
        /// <param name="cancellationToken"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private async Task MockChipEncodingPersonalization(EncoderLoadedMessage message, IntegrationApi api, CancellationToken cancellationToken)
        {
            const string completionMessageTemplate = "CorrelationId: {CorrelationId}, job id: {JobId}, Chip Perso: {OperationOutcome}, workflow: {WorkflowInstanceId}";

            try
            {
                if (cancellationToken.IsCancellationRequested)
                    return;

                var cancelRate     = configuration.GetValue("CancelErrorRate", 0);
                var errorRate      = configuration.GetValue("EncodingErrorRate", 0);
                var value          = _random.Next(0, 100);
                var batchSize      = configuration.GetValue("BatchSize", 0);
                var shouldFailLast = configuration.GetValue("FailLast", false) && batchSize > 0 && counters.StartSignals == batchSize;
                var outcome = value < errorRate || shouldFailLast
                    ? ExternalProcessOutcome.Faulted
                    : ExternalProcessOutcome.Completed;

                if (value < cancelRate)
                    outcome = ExternalProcessOutcome.Canceled;

                var configuredDuration = configuration.GetValue<string>("MockEncodingDuration");
                var encoderId          = message.EncoderId;

                var duration = TimeSpan.Parse(
                    encoderId.Contains("qa")
                        ? "00:00:02"
                        : configuredDuration
                );

                if (outcome == ExternalProcessOutcome.Completed)
                    await Task.Delay(duration, cancellationToken)
                        .ConfigureAwait(false);

                var responseMessage = new ExternalProcessCompletedMessage
                {
                    // We tell AIDA chip personalization completed without error
                    Outcome = outcome,
                    // This is the WorkflowInstanceId we received in the webhook notification
                    WorkflowInstanceId = message.WorkflowInstanceId
                };

                logger.LogDebug("Encoding completed {@EncodingCompleted}", responseMessage);

                switch (outcome)
                {
                    case ExternalProcessOutcome.Faulted:
                        logger.LogDebug(
                            completionMessageTemplate,
                            message.CorrelationId,
                            message.JobId, outcome,
                            message.WorkflowInstanceId
                        );
                        break;
                    case ExternalProcessOutcome.Canceled:
                        logger.LogDebug(
                            completionMessageTemplate,
                            message.CorrelationId,
                            message.JobId, outcome,
                            message.WorkflowInstanceId
                        );
                        break;
                    case ExternalProcessOutcome.Completed:
                        logger.LogDebug(
                            completionMessageTemplate,
                            message.CorrelationId,
                            message.JobId, outcome,
                            message.WorkflowInstanceId
                        );
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                counters.Encoding--;

                // tell AIDA to dispatch the completion signal and resume 
                await api.SignalExternalProcessCompletedAsync(
                        // waitForCompletion = false tells aida to return immediately the HTTP response without waiting the workflow to finish 
                        waitForCompletion: false,
                        // The response message
                        externalProcessCompletedMessage: responseMessage,
                        cancellationToken
                    )
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                logger.LogError(e, "{ExceptionMessage}", e.Message);
            }
        }
    }
}