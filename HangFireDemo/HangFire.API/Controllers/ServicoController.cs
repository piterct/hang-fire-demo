using Hangfire;
using HangFire.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace HangFire.API.Controllers
{
    public class ServicoController : Controller
    {
        private readonly INotificacao _notificacao;

        public ServicoController(INotificacao notificacao)
        {
            _notificacao = notificacao;
        }

        [HttpGet("executarUmaVez")]
        public IActionResult ExecutaUmavez()
        {
            var jobFireForget = BackgroundJob.Enqueue(() => _notificacao.Notifica());

            return Ok();
        }
    }
}
