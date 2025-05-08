using System;
using System.Text.Json;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Logging;

namespace Aida.Samples.Integration.Webhooks
{
    public static class JsonElementExtensions
    {
        public static bool TryParseWorkflowMessage(this JsonElement json, JsonSerializerOptions serializerOptions, ILogger logger, out WorkflowMessage? message)
        {
            message = null;
            try
            {
                if (!Enum.TryParse<MessageType>(json.GetProperty("messageType").GetString(), out var messageType))
                {
                    return false;
                }

                var jsonString = json.ToString();
                message = messageType switch
                {
                    MessageType.WorkflowSchedulerSuspended => JsonSerializer.Deserialize<WorkflowSchedulerProcessSuspendedMessage>(jsonString, serializerOptions),
                    MessageType.WorkflowSchedulerStopping  => JsonSerializer.Deserialize<WorkflowSchedulerStoppingMessage>(jsonString, serializerOptions),
                    MessageType.WorkflowSchedulerStarted   => JsonSerializer.Deserialize<WorkflowSchedulerStartedMessage>(jsonString, serializerOptions),
                    MessageType.WorkflowSchedulerStopped   => JsonSerializer.Deserialize<WorkflowSchedulerStoppedMessage>(jsonString, serializerOptions),
                    MessageType.WorkflowStarted            => JsonSerializer.Deserialize<WorkflowStartedMessage>(jsonString, serializerOptions),
                    MessageType.WorkflowCancelled          => JsonSerializer.Deserialize<WorkflowCancelledMessage>(jsonString, serializerOptions),
                    MessageType.WorkflowCompleted          => JsonSerializer.Deserialize<WorkflowCompletedMessage>(jsonString, serializerOptions),
                    MessageType.WorkflowFaulted            => JsonSerializer.Deserialize<WorkflowFaultedMessage>(jsonString, serializerOptions),
                    MessageType.EncoderLoaded              => JsonSerializer.Deserialize<EncoderLoadedMessage>(jsonString, serializerOptions),
                    MessageType.OcrExecuted                => JsonSerializer.Deserialize<OcrExecutedMessage>(jsonString, serializerOptions),
                    MessageType.HealthCheck                => JsonSerializer.Deserialize<WebhookReceiverHealthCheckMessage>(jsonString, serializerOptions),
                    MessageType.MagneticStripeReadBack     => JsonSerializer.Deserialize<MagneticStripeReadBackMessage>(jsonString, serializerOptions),
                    MessageType.OcrReadBack                => JsonSerializer.Deserialize<OcrReadBackMessage>(jsonString, serializerOptions),
                    MessageType.ChipReadBack               => JsonSerializer.Deserialize<ChipReadBackMessage>(jsonString, serializerOptions),
                    MessageType.BarcodeReadBack            => JsonSerializer.Deserialize<BarcodeReadBackMessage>(jsonString, serializerOptions),
                    _                                      => null
                };
                return message != null;
            }
            catch (Exception e)
            {
                logger.LogError(e, e.Message);
                return false;
            }
        }
    }
}