using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CondominioSmart.Services
{
    public interface IMessegeService
    {
        Task PopUpMensagem(string mensagemAlerta);
        Task PopUpMensagemConfirmacao(string mensagemAlerta);
    }
}
