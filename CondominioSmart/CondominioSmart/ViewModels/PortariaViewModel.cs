using CondominioSmart.Views.PopUps;
using Rg.Plugins.Popup.Contracts;
using Rg.Plugins.Popup.Services;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class PortariaViewModel : BaseViewModel
    {
        #region Propriedade

        #endregion

        #region Commands
        public ICommand PopUpCheckOKLoadCommand { get { return new Command(OnPopUpCheckOkLoad); } }

        #endregion

        #region Construtor

        #endregion

        #region Métodos

        private async void OnPopUpCheckOkLoad(object obj)
        {
            PopupNavigation.PushAsync(new PopUpCheckOk());
        }
        #endregion
    }
}