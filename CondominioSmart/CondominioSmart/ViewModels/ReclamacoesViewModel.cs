using CondominioSmart.Models;
using CondominioSmart.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ReclamacoesViewModel : BaseViewModel
    {
        #region Propriedade
        private string _titleReclamacao;

        public string TitleReclamacao
        {
            get { return _titleReclamacao; }
            set { SetProperty(ref _titleReclamacao, value); }
        }


        private string _textReclamacao;

        public string TextReclamacao
        {
            get { return _textReclamacao; }
            set { SetProperty(ref _textReclamacao, value); }
        }

        private readonly IMessegeService _messegeService;
        private readonly IReclamacaoRepository _reclamacaoRepository;
        #endregion

        #region Commands
        public ICommand AddCommand { get { return new Command(OnAddExecute); } }

        #endregion

        #region Construtor
        public ReclamacoesViewModel()
        {
            _reclamacaoRepository = new ReclamacaoRepository();
        }
        #endregion

        #region Métodos

        private void OnAddExecute(object obj)
        {
            if (!String.IsNullOrWhiteSpace(TitleReclamacao))
            {
                MessagingCenter.Send(new Reclamacao {TextReclamacao = this.TextReclamacao, TitleReclamacao = this.TitleReclamacao}, "Confirmacao");
                //Ao ser chamado, dispara a ação de quem estiver ouvindo, validado pela assinatura que neste 
                //caso é a string "confirmacao"
                var reclamacao = new Reclamacao()
                { TextReclamacao = this.TextReclamacao, TitleReclamacao = this.TitleReclamacao };
                _reclamacaoRepository.Insert(reclamacao);
            }
        }
        #endregion
    }
}

