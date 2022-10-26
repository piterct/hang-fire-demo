using HangFire.API.Interfaces;
using System;
using System.Threading.Tasks;

namespace HangFire.API.Notificacao
{
    public class Notifica : INotificacao
    {
        public async Task<bool> NotificaOk()
        {
            Console.WriteLine("Notifiquei");
            return await  Task.FromResult(true);
        }

        public async Task<bool> NotificaPorMinuto()
        {
            Console.WriteLine("Notifiquei");
            return await Task.FromResult(true);
        }
    }
}
