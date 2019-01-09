using CondominioSmart.DataBase;
using CondominioSmart.Models;
using CondominioSmart.Services;
using CondominioSmart.Views.PopUps;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ReclamacaoTabbedViewModel : BaseViewModel
    {
        #region Propriedade
        private int _contador = 0;

        public int Contador
        {
            get { return _contador; }
            set { SetProperty(ref _contador, value); }
        }

        private readonly RealmRepository<Reclamacao> _realmRepository;
        private readonly ReclamacaoRepository _reclamacaoRepository;



        #endregion

        #region Commands

        #endregion

        #region Construtor
        public ReclamacaoTabbedViewModel()
        {
           // _realmRepository = new RealmRepository<Reclamacao>();
            _reclamacaoRepository = new ReclamacaoRepository();

            MudarContador();
            Init();
        }
        #endregion

        #region Métodos

        private void MudarContador()
        {
            MessagingCenter.Subscribe<Reclamacao>(this, "Confirmacao", message =>
            {
                Init();
            });
        }

        private void Init()
        {
            try
            {
                Contador = _reclamacaoRepository.GetAll().Count;
            }
            catch (Exception Ex)
            {
                App.Current.MainPage.DisplayAlert("", Ex.Message, "ok");
            }
        }
        #endregion
    }
}
