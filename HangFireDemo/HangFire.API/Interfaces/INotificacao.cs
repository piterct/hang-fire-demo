using System;
using System.Threading.Tasks;

namespace HangFire.API.Interfaces
{
    public interface INotificacao
    {
        Task<bool> Notifica();
    }
}
