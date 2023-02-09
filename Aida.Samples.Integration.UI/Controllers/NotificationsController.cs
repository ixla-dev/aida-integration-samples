using System;
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
        private readonly ILogger<WebHooksController> _logger;
        private readonly WebhooksHandler             _webhooksHandler;
        public WebHooksController(
            WebhooksHandler webhooksHandler,
            ILogger<WebHooksController> logger)
        {
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
        public Task<ActionResult> OnWebhookReceived(
            [FromBody] JsonElement jsonMessage)
        {
            var jsonOptions = new JsonSerializerOptions();
            // enable string -> Enum parsing in the json serializer
            jsonOptions.Converters.Add(new JsonStringEnumConverter());

            // Parse messages sent by AIDA: 
            // Polymorphic deserialization can be achieved also using a custom json converter for system.text.json 
            // but i didn't want to implement it, since it would be pretty much overkill for deserializing only 2 
            // different message types

            var             type    = Enum.Parse<MessageType>(jsonMessage.GetProperty("MessageType").GetString() ?? "");
            WorkflowMessage message = null;

            try
            {
                switch (type)
                {
                    case MessageType.HealthCheck:
                        var healthCheck = jsonMessage.Deserialize<WebhookReceiverHealthCheckMessage>(jsonOptions);
                        break;
                    // Whe webhooks are enabled, the workflow scheduler will try to publish the WorkflowSchedulerStarted message
                    // If the webhooks receiver does not send back a successful http response, the WorkflowScheduler will be stopped
                    // with error code WebhooksReceiver unreachable 
                    case MessageType.WorkflowSchedulerStarted:
                        var started = jsonMessage.Deserialize<WorkflowSchedulerStartedMessage>(jsonOptions);
                        break;
                    // Sent by workflow instances when there are no more cards in the feeder
                    // We know the feeder is empty only after trying to move the card because 
                    // there are no sensors in the feeder 
                    case MessageType.FeederEmpty:
                        var feederEmpty = jsonMessage.Deserialize<FeederEmptyMessage>(jsonOptions);
                        _webhooksHandler.OnFeederEmpty(feederEmpty);
                        break;
                    case MessageType.WorkflowCancelled:
                        var cancelled = jsonMessage.Deserialize<WorkflowCancelledMessage>(jsonOptions);
                        // no-op 
                        // AIDA sends this when the workflow engine triggers the workflow cancelled event which 
                        // indicates that a running/suspended workflow was cancelled programmatically 
                        break;
                    case MessageType.WorkflowCompleted:
                        var complete = jsonMessage.Deserialize<WorkflowCompletedMessage>(jsonOptions);
                        _webhooksHandler.OnWorkflowCompleted(complete);
                        break;
                    case MessageType.WorkflowFaulted:
                        var fault = jsonMessage.Deserialize<WorkflowFaultedMessage>(jsonOptions);
                        _webhooksHandler.OnWorkflowFaulted(fault);
                        break;
                    // message sent by AIDA containing OCR results 
                    case MessageType.OcrExecuted:
                        message = jsonMessage.Deserialize<OcrExecutedMessage>(jsonOptions);
                        break;
                    // message sent by AIDA when the card is in the encoder position 
                    case MessageType.EncoderLoaded:
                        message = jsonMessage.Deserialize<EncoderLoadedMessage>(jsonOptions);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            if (message is null)
                return Task.FromResult<ActionResult>(Ok());

            // webhooks handler is just a service that keeps track of received messages 
            // and is used to notify AIDA interactively from the UI. Of course in real applications
            // this can be replaced with whatever you need to handle encoding / ocr results validation
            _webhooksHandler.Add(message);

            return Task.FromResult<ActionResult>(Ok());
        }
    }
}