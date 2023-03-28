using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Aida.Samples.Integration.UI.Services;
using Aida.Sdk.Mini.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Aida.Samples.Integration.UI.Controllers
{
    [ApiController]
    public class WebHooksController : ControllerBase
    {
        private readonly JsonSerializerOptions       _jsonOptions;
        private readonly ILogger<WebHooksController> _logger;
        private readonly WebhooksHandler             _webhooksHandler;
        public WebHooksController(
            JsonSerializerOptions jsonOptions,
            WebhooksHandler webhooksHandler,
            ILogger<WebHooksController> logger)
        {
            _jsonOptions = jsonOptions;
            _webhooksHandler = webhooksHandler;
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("index")]
        public ActionResult<string> Index()
        {
            return Ok("webhooks receiver");
        }

        /// <summary>
        /// This is the endpoint that receives webhooks from AIDA. Messages sent by AIDA can be 
        /// distinguished by "MessageType". 
        /// </summary>
        /// <param name="jsonMessage"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("/ixla/aida/v1/webhooks")]
        public async Task<ActionResult> OnWebhookReceived([FromBody] JsonElement json)
        {
            try
            {
                var jsonOptions = new JsonSerializerOptions();
                // enable string -> Enum parsing in the json serializer
                jsonOptions.Converters.Add(new JsonStringEnumConverter());

                // Parse messages sent by AIDA: 
                // Polymorphic deserialization can be achieved also using a custom json converter for system.text.json 
                // but i didn't want to implement it, since it would be pretty much overkill for deserializing only 2 
                // different message types

                var message = DeserializeMessage(json);
                switch (message)
                {
                    case null:
                        return BadRequest("Unsupported message type");
                    case WorkflowCompletedMessage wfCompleted:
                        _webhooksHandler.OnWorkflowCompleted(wfCompleted);
                        break;
                    case WorkflowFaultedMessage wfFault:
                        _webhooksHandler.OnWorkflowFaulted(wfFault);
                        break;
                }

                _webhooksHandler.Add(message);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /// <summary>
        /// Deserialize messages. In the demo app i was using models defined in the project, now we are using the models from the SDK 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        private WorkflowMessage DeserializeMessage(JsonElement json)
        {
            try
            {
                if (!Enum.TryParse<MessageType>(json.GetProperty("MessageType").GetString(), out var messageType))
                    return null;
                var jsonString = json.ToString();
                _logger.LogInformation("Parsing {@MessageType}", messageType);
                _logger.LogInformation("Raw Content {@RawContent}", jsonString);
                _logger.LogInformation("Message {@JsonMessage}", JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString));

                if (jsonString is null)
                    return null;

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
                    MessageType.HealthCheck                => JsonSerializer.Deserialize<WebhookReceiverHealthCheckMessage>(jsonString, _jsonOptions),
                    _                                      => null
                };
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                return null;
            }
        }
    }
}