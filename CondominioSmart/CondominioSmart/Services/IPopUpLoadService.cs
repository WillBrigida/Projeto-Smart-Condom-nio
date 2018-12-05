using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CondominioSmart.Services
{
    public interface IPopUpLoadService
    {
        Task PopUpMensagem(string titulo, string mensagem );
    }
}
