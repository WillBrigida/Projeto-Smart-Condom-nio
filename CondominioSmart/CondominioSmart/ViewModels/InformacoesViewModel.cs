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

        #endregion

        #region Commands
        public ICommand MoradoresCommand { get { return new Command(OnMoradoresExecute); } }

        #endregion

        #region Construtor
        public InformacoesViewModel()
        {

        }
        #endregion

        #region Métodos

        private async void OnMoradoresExecute(object obj)
        {
            await Navigation.PushAsync<ListaMoradoresViewModel>(false);
        }
        #endregion
    }
}
