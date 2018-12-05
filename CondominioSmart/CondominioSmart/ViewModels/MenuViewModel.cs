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


        private readonly INavigationService _navigationService;
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
            _navigationService = DependencyService.Get<INavigationService>();   
        }
        #endregion

        #region Métodos

        private void OnReclamacoesCommandExecute(object obj)
        {
            this._navigationService.NavigationForReclamacaoTabbedPagePage();
        }


        private void OnInformacoesCommandExecute(object obj)
        {
            this._navigationService.NavigationForInformacoesPage();
        }


        private void OnPortariaCommandExecute(object obj)
        {
            this._navigationService.NavigationForPortariaPage();
        }


        private void OnAtendimentosCommandExecute(object obj)
        {
            this._navigationService.NavigationForAtendimentosPage();
        }


        private async void OnScannerCommandExecute(object obj)
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new ScannerPage());
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