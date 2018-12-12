using CondominioSmart.Views.PopUps;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class PopsViewModel : BaseViewModel
    {
        #region Propriedade

        #endregion

        #region Commands
        public ICommand PopUpCheckOKLoadCommand { get { return new Command(OnPopUpCheckOkLoad); } }
        public ICommand PopUpLoadCommand { get { return new Command(OnPopULoadExecute); } }
        public ICommand PopUpPageCommand { get { return new Command(OnPopUpPageExecute); } }

        #endregion

        #region Construtor

        #endregion

        #region Métodos

        private async void OnPopUpCheckOkLoad(object obj)
        {
            PopupNavigation.PushAsync(new PopUpCheckOk());
        }

        private void OnPopULoadExecute(object obj)
        {
            PopupNavigation.PushAsync(new PopUpLoadPage());

        }

        private void OnPopUpPageExecute(object obj)
        {
            PopupNavigation.PushAsync(new PopUpPage());

        }

        #endregion
    }
}
