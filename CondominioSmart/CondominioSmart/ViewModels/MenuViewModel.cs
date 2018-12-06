using CondominioSmart.Services;
using CondominioSmart.Views;
using CondominioSmart.Views.PopUps;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        #region Propriedade
        private string _entry;

        public string Entry
        {
            get { return _entry; }
            set {SetProperty(ref _entry , value); }
        }


        private readonly IMessegeService _messegeService;
        #endregion

        #region Commands
        public ICommand ReclamacoesCommand { get { return new Command(OnReclamacoesCommandExecute); } }
        public ICommand InformacoesCommand { get { return new Command(OnInformacoesCommandExecute); } }
        public ICommand PortariaCommand { get { return new Command(OnPortariaCommandExecute); } }
        public ICommand AtendimentosCommand { get { return new Command(OnAtendimentosCommandExecute); } }
        public ICommand ScannerCommand { get { return new Command(OnScannerCommandExecute); } }


        #endregion

        #region Construtor
        public MenuViewModel()
        {
        }
        #endregion

        #region Métodos

        private async void OnReclamacoesCommandExecute(object obj)
        {
            await Navigation.PushAsync<ReclamacaoTabbedViewModel>(false);
        }


        private async void OnInformacoesCommandExecute(object obj)
        {
            await Navigation.PushAsync<InformacoesViewModel>(false);
        }


        private async void OnPortariaCommandExecute(object obj)
        {
            await Navigation.PushAsync<PortariaViewModel>(false);
        }


        private async void OnAtendimentosCommandExecute(object obj)
        {
            await Navigation.PushAsync<AtendimentosViewModel>(false);
        }


        private async void OnScannerCommandExecute(object obj)
        {
            await Navigation.PushAsync<ScannerViewModel>(true);

        }
        #endregion
    }
}



//#region Propriedade

//#endregion

//#region Commands

//#endregion

//#region Construtor

//#endregion

//#region Métodos

//#endregion