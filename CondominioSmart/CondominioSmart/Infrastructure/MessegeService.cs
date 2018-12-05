using CondominioSmart.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CondominioSmart.Infrastructure
{
    public class MessegeService : IMessegeService
    {
        public async Task PopUpMensagem(string mensagem)
        {
            await App.Current.MainPage.DisplayAlert("Alerta", mensagem, "Ok");
        }

        public async Task PopUpMensagemConfirmacao(string mensagemConfirmacao)
        {
            await App.Current.MainPage.DisplayAlert("Alerta", mensagemConfirmacao, "Sim","Não" );

        }
    }
}
