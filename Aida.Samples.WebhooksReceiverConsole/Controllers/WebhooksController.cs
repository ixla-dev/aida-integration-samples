using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;
using Aida.Sdk.Mini.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Aida.Samples.WebhooksReceiverConsole.Controllers
{
    [ApiController]
    public class WebhooksController : ControllerBase
    {
        private readonly JsonSerializerOptions       _jsonOptions;
        private readonly ILogger<WebhooksController> _logger;
        public WebhooksController(
            JsonSerializerOptions jsonOptions,
            ILogger<WebhooksController> logger)
        {
            _jsonOptions = jsonOptions;
            _logger = logger;
        }

        [HttpGet]
        [Route("/")]
        public ActionResult Home()
        {
            return Ok("Webhooks handler");
        }

        [HttpPost]
        [Route("ixla/aida/v1/webhooks")]
        public ActionResult OnWebhookMessage(
            [FromServices] MessageCollection messageQueue,
            [FromBody] JsonElement receivedMessage)
        {
            var message = DeserializeMessage(receivedMessage);
            // If the payload does not contain a known message type we short-circuit the request
            // and respond with 400 bad request to the client
            if (message == null) return BadRequest();
            // log the received message from AIDA
            _logger.LogInformation("Received Message {@Message}", JsonSerializer.Serialize(receivedMessage, new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new JsonStringEnumConverter() }
            }));
            // Add the message in an unbounded blocking collection for further processing 
            messageQueue.AddMessage(message);
            return Ok();
        }


        /// <summary>
        /// Deserialize messages. In the demo app i was using models defined in the project, now we are using the models from the SDK 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        private WorkflowMessage DeserializeMessage(JsonElement json)
        {
            if (!Enum.TryParse<MessageType>(json.GetProperty("MessageType").GetString(), out var messageType))
                return null;
            var jsonString = json.ToString();
            if (jsonString is null) return null;
            return messageType switch
            {
                MessageType.WorkflowSchedulerStarted   => JsonSerializer.Deserialize<WorkflowSchedulerStartedMessage>(jsonString, _jsonOptions),
                MessageType.WorkflowSchedulerSuspended => JsonSerializer.Deserialize<WorkflowSchedulerProcessSuspendedMessage>(jsonString, _jsonOptions),
                MessageType.WorkflowSchedulerStopped   => JsonSerializer.Deserialize<WorkflowSchedulerStoppedMessage>(jsonString, _jsonOptions),
                MessageType.EncoderLoaded              => JsonSerializer.Deserialize<EncoderLoadedMessage>(jsonString, _jsonOptions),
                MessageType.OcrExecuted                => JsonSerializer.Deserialize<OcrExecutedMessage>(jsonString, _jsonOptions),
                MessageType.WorkflowCancelled          => JsonSerializer.Deserialize<WorkflowCancelledMessage>(jsonString, _jsonOptions),
                MessageType.WorkflowCompleted          => JsonSerializer.Deserialize<WorkflowCompletedMessage>(jsonString, _jsonOptions),
                MessageType.WorkflowFaulted            => JsonSerializer.Deserialize<WorkflowFaultedMessage>(jsonString, _jsonOptions),
                MessageType.FeederEmpty                => JsonSerializer.Deserialize<FeederEmptyMessage>(jsonString, _jsonOptions),
                _                                      => null
            };
        }
    }
}