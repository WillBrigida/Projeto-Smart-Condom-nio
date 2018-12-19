using CondominioSmart.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Propriedade
        private bool _confirmacao;
        
        public bool Confirmacao
        {
            get { return _confirmacao; }
            set {SetProperty(ref _confirmacao , value); }
        }


        private readonly IMessegeService _messegeService;
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new Command(OnLoginCommandExecute); } }
        #endregion

        #region Construtor
        public LoginViewModel()
        {
            Confirmacao = true;
        }
        #endregion

        #region Métodos

        private async void OnLoginCommandExecute(object obj)
        {
            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;
            IsRunning = true;
            await Task.Delay(5000);

           
            await App.Current.MainPage.Navigation.PopModalAsync();
            IsRunning = false;

        }

        #endregion
    }
}
