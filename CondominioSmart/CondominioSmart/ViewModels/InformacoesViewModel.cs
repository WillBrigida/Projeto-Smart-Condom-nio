using CondominioSmart.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class InformacoesViewModel : BaseViewModel
    {
        #region Propriedade
        Helpers.FontAwesome fontAwesome;

        private string _icon;

        public string Icon
        {
            get { return _icon; }
            set {SetProperty(ref _icon , value); }
        }

        #endregion

        #region Commands
        public ICommand MoradoresCommand { get { return new Command(OnMoradoresExecute); } }

        #endregion

        #region Construtor
        public InformacoesViewModel()
        {
            fontAwesome = new Helpers.FontAwesome();
            Icon = Helpers.FontAwesome.Film;
        }
        #endregion

        #region Métodos

        private async void OnMoradoresExecute(object obj)
        {
            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;
            //await Navigation.PushAsync<ListaMoradoresViewModel>(false);
            await navPage.PushAsync(new ListaMoradoresPage());
        }


        #endregion
    }
}
