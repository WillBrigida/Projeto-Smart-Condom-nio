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
            ListaReclamacao = new ObservableCollection<Reclamacao>(List());
            AdicionarLista();
        }
        #endregion

        #region Métodos
        private void AdicionarLista()
        {
            MessagingCenter.Subscribe<Reclamacao>(this, "Confirmacao", message =>
            {
                _reclamacaoRepository.Insert(message);

            });
        }

        private List<Reclamacao> List()
        {
            return _reclamacaoRepository.GetAll();
        }
        #endregion

        private async void OnDetalheExecute(Reclamacao reclamacao)
        {
            await Navigation.PushAsync<DetalheViewModel>(false, reclamacao);
        }



    }
}

