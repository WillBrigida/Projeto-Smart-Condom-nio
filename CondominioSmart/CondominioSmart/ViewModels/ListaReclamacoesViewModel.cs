using CondominioSmart.Models;
using CondominioSmart.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ListaReclamacoesViewModel : BaseViewModel
    {
        #region Propriedade
        private readonly IReclamacaoRepository _reclamacaoRepository;

        private ObservableCollection<Teste> _listaReclamacao;

        public ObservableCollection<Teste> ListaReclamacao
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
            ListaReclamacao = new ObservableCollection<Teste>();
            AdicionarLista();
        }
        #endregion

        #region Métodos
        private void AdicionarLista()
        {
            MessagingCenter.Subscribe<Teste>(this, "Confirmacao", message =>
            {
                // _reclamacaoRepository.Insert(message);
                ListaReclamacao.Add(message);
            });
        }

        //private List<Reclamacao> List()
        //{
        //    //return _reclamacaoRepository.GetAll();
        //}

        //private void Init()
        //{
        //    ListaReclamacao = new ObservableCollection<Reclamacao>(List());
        //}
        #endregion

        private async void OnDetalheExecute(Reclamacao reclamacao)
        {
            await Navigation.PushAsync<DetalheViewModel>(false, reclamacao);
        }



    }
}

