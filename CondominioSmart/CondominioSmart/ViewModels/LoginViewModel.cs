using CondominioSmart.Services;
using System;
using System.Collections.Generic;
using System.Text;
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


        private readonly INavigationService _navigationService;
        private readonly IMessegeService _messegeService;
        #endregion

        #region Commands
        public ICommand LoginCommand { get { return new Command(OnLoginCommandExecute); } }
        #endregion

        #region Construtor
        public LoginViewModel()
        {
            _navigationService = DependencyService.Get<INavigationService>();
            Confirmacao = true;
        }
        #endregion

        #region Métodos

        private void OnLoginCommandExecute(object obj)
        {
            _navigationService.NavigationForMenu();
        }

        #endregion
    }
}
