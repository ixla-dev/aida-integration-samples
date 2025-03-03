using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Aida.Samples.Integration.Webhooks;
using Aida.Samples.WebhooksReceiverConsole.HostedServices;
using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;
using Aida.Sdk.Mini.Model;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Aida.Samples.WebhooksReceiverConsole.Controllers
{
    [ApiController]
    public class WebhooksController : ControllerBase
    {
        private readonly ApiClientFactory            _apiClientFactory;
        private readonly GlobalCounters              _counters;
        private readonly JsonSerializerOptions       _jsonOptions;
        private readonly ILogger<WebhooksController> _logger;

        public WebhooksController(
            ApiClientFactory apiClientFactory,
            GlobalCounters counters,
            JsonSerializerOptions jsonOptions,
            ILogger<WebhooksController> logger)
        {
            _apiClientFactory = apiClientFactory;
            _counters = counters;
            _jsonOptions = jsonOptions;
            _logger = logger;
        }

        [HttpGet("/file")]
        public ActionResult GetFile() => Ok($"bytea IMG_PHOTO\n" +
                                            $"text  TYPE\n" +
                                            $"text  COUNTRY_CODE\n" +
                                            $"text  PASSPORT_NUMBER\n" +
                                            $"text  SURNAME\n" +
                                            $"text  GIVEN_NAMES\n" +
                                            $"text  NATIONALITY\n" +
                                            $"text  IDNRL\n" +
                                            $"text  IDNRLL2\n" +
                                            $"text  PERSONAL_NUMBER\n" +
                                            $"text  DATE_OF_BIRTH\n" +
                                            $"text  SEX\n" +
                                            $"text  PLACE_OF_BIRTH\n" +
                                            $"text  DATE_OF_ISSUE\n" +
                                            $"text  DATE_OF_EXPIRY\n" +
                                            $"bytea IMG_SIGNATURE\n" +
                                            $"text  MRZ_1\n" +
                                            $"text  MRZ_2\n" +
                                            $"bytea PHOTO_1");

        [HttpGet]
        [Route("/")]
        public ActionResult Home() => Ok("Webhooks handler");

        [HttpPost]
        [Route("ixla/aida/v1/webhooks")]
        public async Task<ActionResult> OnWebhookMessage(
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
                _logger.LogInformation("[{IPAddress}] Received Message {@WebhookMessage}", address, JsonSerializer.Serialize(receivedMessage, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Converters = { new JsonStringEnumConverter() },
                }));

            _counters.ProcessMessage(message);
            var batchSize = configuration.GetValue("BatchSize", 0);
            if (batchSize > 0)
            {
                if (_counters.StartSignals == batchSize)
                {
                    var client = _apiClientFactory(address);
                    await client.StopWorkflowSchedulerAsync(false, JobErrorCodes.NoErrors, CancellationToken.None);
                }
            }

            // Add the message in an unbounded blocking collection for further processing 
            messageQueue.Enqueue(new MachineMessage(address, message));
            return Ok();
        }

        [HttpGet("/counters")]
        public ActionResult GetCounters([FromServices] SessionCounters counters) => Ok(counters);
    }
}