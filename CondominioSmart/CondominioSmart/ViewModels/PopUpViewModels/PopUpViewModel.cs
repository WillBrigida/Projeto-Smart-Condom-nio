using CondominioSmart.Services;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels.PopUpViewModels
{
    public class PopUpViewModel : BaseViewModel
    {
        #region Propriedades
        private readonly IMessegeService _messegeService;
        #endregion

        #region Construtor
        public PopUpViewModel()
        {

        }
        #endregion

        #region Commands
        public ICommand BackPopUpCommand { get { return new Command(OnBackPopUpExecute); } }


        #endregion

        #region Métodos

        private async void OnBackPopUpExecute()
        {
        }

        #endregion
    }
}
