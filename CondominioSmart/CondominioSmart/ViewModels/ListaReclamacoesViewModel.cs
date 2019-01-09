using CondominioSmart.DataBase;
using CondominioSmart.Models;
using CondominioSmart.Services;
using Realms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ListaReclamacoesViewModel : BaseViewModel
    {
        #region Propriedade
        private readonly RealmRepository<Reclamacao> _realmRepository;
        private readonly ReclamacaoRepository _reclamacaoRepository;


        private ObservableCollection<Reclamacao> _listaReclamacao;

        public ObservableCollection<Reclamacao> ListaReclamacao
        {
            get { return _listaReclamacao; }
            set { SetProperty(ref _listaReclamacao, value); }
        }


        #endregion

        #region Commands
        public ICommand DetalheCommand { get { return new Command<Reclamacao>(OnDetalheExecute); } }
        #endregion

        #region Construtor
        public ListaReclamacoesViewModel()
        {
            _reclamacaoRepository = new ReclamacaoRepository();

           // _realmRepository = new RealmRepository<Reclamacao>();
            AdicionarLista();
            Init();
        }
        #endregion

        #region Métodos
        private void AdicionarLista()
        {
            MessagingCenter.Subscribe<Reclamacao>(this, "Confirmacao", message =>
            {
                try
                {
                    _reclamacaoRepository.Insert(message);
                    Init();
                }
                catch (Exception Ex)
                {
                    App.Current.MainPage.DisplayAlert("", Ex.Message, "ok");
                }
            });
        }

        private List<Reclamacao> List()
        {
            return _reclamacaoRepository.GetAll();
        }

        private void Init()
        {
            var listaReclamacao = List();
            ListaReclamacao = new ObservableCollection<Reclamacao>(listaReclamacao);
        }
        #endregion

        private async void OnDetalheExecute(Reclamacao reclamacao)
        {
            await Navigation.PushAsync<DetalheViewModel>(false, reclamacao);
        }
    }
}

