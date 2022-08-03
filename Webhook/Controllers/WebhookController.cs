using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webhook.Models;

namespace Webhook.Controllers
{
    [Route("api/")]
    [ApiController]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger<WebhookController> _logger;
        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        [HttpPost("pix")]
        public async Task<IActionResult> NotificacaoPix([FromBody] NotificacaoPixModel notificacao)
        {
            _logger.LogInformation("Pix Recebido {txid}", notificacao.Pix[0].Txid);
            return Ok();
        }
    }
}
