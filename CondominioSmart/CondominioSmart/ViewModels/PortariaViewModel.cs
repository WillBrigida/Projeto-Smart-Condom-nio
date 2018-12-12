using CondominioSmart.Services;
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
        private readonly IMessageAlert _messageAlert;
        #endregion

        #region Commands
        public ICommand FuncionariosCommand { get { return new Command(OnFuncionariosExecute); } }
        public ICommand ContatosCommand { get { return new Command(OnContatosExecute); } }
        public ICommand CorrespondenciaCommand { get { return new Command(OnCorrespondenciaExecute); } }

        #endregion

        #region Construtor
        public PortariaViewModel()
        {
            _messageAlert = DependencyService.Get<IMessageAlert>();
        }
        #endregion

        #region Métodos
        private void OnFuncionariosExecute(object obj)
        {
            _messageAlert.ShortAlert("Tela Funcionários");
        }


        private void OnContatosExecute(object obj)
        {
            _messageAlert.ShortAlert("Tela Contatos");
        }


        private void OnCorrespondenciaExecute(object obj)
        {
            _messageAlert.ShortAlert("Tela Correspondência");
        }
        #endregion
    }
}