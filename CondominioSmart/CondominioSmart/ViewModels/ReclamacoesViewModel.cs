using CondominioSmart.Models;
using CondominioSmart.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ReclamacoesViewModel : BaseViewModel
    {
        #region Propriedade
        private string _textoEntry;

        public string TextoEntry
        {
            get { return _textoEntry; }
            set { SetProperty(ref _textoEntry, value); }
        }

        private readonly IMessegeService _messegeService;
        #endregion

        #region Commands
        public ICommand AddCommand { get { return new Command(OnAddExecute); } }

        #endregion

        #region Construtor
        public ReclamacoesViewModel()
        {
        }
        #endregion

        #region Métodos

        private  void OnAddExecute(object obj)
        {
            if (!String.IsNullOrWhiteSpace(TextoEntry))
            {
                MessagingCenter.Send(new Message { Titulo = "Novo Item", Valor = TextoEntry }, "Confirmacao");
            }
        }
        #endregion
    }
}
