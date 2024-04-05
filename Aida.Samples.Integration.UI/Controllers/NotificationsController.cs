using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Aida.Samples.Integration.UI.Services;
using Aida.Samples.Integration.Webhooks;
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
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("index")]
        public ActionResult<string> Index() => Ok("webhooks receiver");

        /// <summary>
        /// This is the endpoint that receives webhooks from AIDA. Messages sent by AIDA can be 
        /// distinguished by "MessageType". 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("/ixla/aida/v1/webhooks")]
        public Task<ActionResult> OnWebhookReceived([FromBody] JsonElement json)
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
                if (!(json.TryParseWorkflowMessage(_jsonOptions, _logger, out var message)))
                    return Task.FromResult<ActionResult>(BadRequest("Unsupported message type"));

                switch (message)
                {
                    case WorkflowCompletedMessage wfCompleted:
                        _webhooksHandler.OnWorkflowCompleted(wfCompleted);
                        break;
                    case WorkflowFaultedMessage wfFault:
                        _webhooksHandler.OnWorkflowFaulted(wfFault);
                        break;
                }
                _webhooksHandler.Add(message);
                return Task.FromResult<ActionResult>(Ok());
            }
            catch (Exception e)
            {
                return Task.FromResult<ActionResult>(BadRequest(e.Message));
            }
        }
    }
}