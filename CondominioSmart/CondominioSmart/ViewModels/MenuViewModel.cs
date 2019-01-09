using CondominioSmart.Helpers;
using CondominioSmart.Services;
using CondominioSmart.Views;
using CondominioSmart.Views.PopUps;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CondominioSmart.ViewModels
{
    public class MenuViewModel : BaseViewModel
    {
        #region Propriedade
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        private string _entry;

        public string Entry
        {
            get { return _entry; }
            set { SetProperty(ref _entry, value); }
        }

        private string _selectedProduct;

      

        private readonly IMessegeService _messegeService;
        #endregion

        #region Commands

        public ICommand NavigationCommand { get { return new Command<MenuItemViewModel>(OnNavigationExecute); } }





        #endregion


        #region Construtor
        public MenuViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>
            {
                new MenuItemViewModel (FontAwesome.Building, "Portaria"),
                new MenuItemViewModel (FontAwesome.Exclamation, "Reclamações"),
                new MenuItemViewModel (FontAwesome.Info, "Informações"),
                new MenuItemViewModel (FontAwesome.Briefcase,  "Atendimentos"),
                new MenuItemViewModel (FontAwesome.Barcode,  "Scanner"),
                new MenuItemViewModel (FontAwesome.PowerOff,  "Login"),

            };
        }
        #endregion

        #region Métodos



        private void OnNavigationExecute(MenuItemViewModel menu)
        {
            var titulo = menu.Titulo;

            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;

            // Hide the Master page
            mdp.IsPresented = false;

            switch (titulo)
            {
                case "Portaria":
                    mdp.Detail = new NavigationPage(new PortariaPage());
                    break;
                case "Reclamações":
                     mdp.Detail = new NavigationPage(new ReclamacaoTabbedPage());
                    break;
                case "Informações":
                    mdp.Detail = new  NavigationPage(new  InformacoesPage());
                    break;
                case "Atendimentos":
                    mdp.Detail = new NavigationPage(new AtendimentosPage());
                    break;
                case "Scanner":
                    mdp.Detail = new NavigationPage(new ScannerPage());
                    break;
                case "Login":
                    mdp.Detail = new NavigationPage(new LoginPage());
                    break;
            }

        }

    }

   
    #endregion
}







//#region Propriedade

//#endregion

//#region Commands

//#endregion

//#region Construtor

//#endregion

//#region Métodos

//#endregion