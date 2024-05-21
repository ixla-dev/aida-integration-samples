using System.Text.Json;
using System.Text.Json.Serialization;
using Aida.Samples.Integration.Webhooks;
using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        public ActionResult Home() => Ok("Webhooks handler");

        [HttpPost]
        [Route("ixla/aida/v1/webhooks")]
        public ActionResult OnWebhookMessage(
            [FromServices] IConfiguration configuration,
            [FromServices] MessageCollection messageQueue,
            [FromBody] JsonElement receivedMessage)
        {
            var address = HttpContext.Features.Get<IHttpConnectionFeature>()?.RemoteIpAddress?.ToString();

            // AsWorkflowMessage is an extension method defined in Aida.Samples.Integration.Webhooks 
            if (!receivedMessage.TryParseWorkflowMessage(_jsonOptions, _logger, out var message))
                // If the payload does not contain a known message type we short-circuit the request
                // and respond with 400 bad request to the client
                return BadRequest();

            // log the received message from AIDA
            if (configuration.GetValue<bool>("LogMessagePayload"))
                _logger.LogTrace("[{IPAddress}] Received Message {@WebhookMessage}", address, JsonSerializer.Serialize(receivedMessage, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Converters = { new JsonStringEnumConverter() },
                }));

            // Add the message in an unbounded blocking collection for further processing 
            messageQueue.Enqueue(new MachineMessage(address, message));
            return Ok();
        }
    }
}