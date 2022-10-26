using Hangfire;
using HangFire.API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
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
            var jobFireForget = BackgroundJob.Enqueue(() => _notificacao.NotificaOk());

            return Ok();
        }

        [HttpGet("rodarAposTempo")]
        public IActionResult RodarAposTempo()
        {
            var jobDelayed = BackgroundJob.Schedule(() => _notificacao.NotificaOk(), TimeSpan.FromSeconds(10));

            return Ok();
        }

        [HttpGet("rodarAposTempoContinuo")]
        public IActionResult RodarAposTempoContinuo()
        {
            var jobDelayed = BackgroundJob.Schedule(() => _notificacao.NotificaOk(), TimeSpan.FromSeconds(10));

            BackgroundJob.ContinueJobWith(jobDelayed, () => _notificacao.NotificaOk());

            return Ok();
        }
    }
}
