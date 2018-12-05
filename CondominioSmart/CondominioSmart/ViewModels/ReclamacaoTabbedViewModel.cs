using CondominioSmart.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ReclamacaoTabbedViewModel : BaseViewModel
    {
        private int _contador;

        public int Contador
        {
            get { return _contador; }
            set { SetProperty(ref _contador, value); }
        }


        public ReclamacaoTabbedViewModel()
        {
            MudarContador();
        }

        int cont = 0;

        private void MudarContador()
        {
            MessagingCenter.Subscribe<Message>(this, "Confirmacao", message =>
            {
                cont++;
                Contador = cont;
            });
        }
    }
}
