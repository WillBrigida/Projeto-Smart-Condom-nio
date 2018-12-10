using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ListaBuscaViewModel : BaseViewModel
    {
        #region Propriedade

        #endregion

        #region Commands
        public ICommand ListaCommand { get { return new Command(OnLIstaExecute); } }

        #endregion

        #region Construtor

        #endregion

        #region Métodos

        private async void OnLIstaExecute(object obj)
        {
            await Navigation.PushAsync<ListaViewModel>(false);
        }
        #endregion
    }
}
