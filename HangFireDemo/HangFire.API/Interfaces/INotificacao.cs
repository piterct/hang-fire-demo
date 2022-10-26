using System;
using System.Threading.Tasks;

namespace HangFire.API.Interfaces
{
    public interface INotificacao
    {
        Task<bool> NotificaOk();
        Task<bool> NotificaPorMinuto();
    }
}
