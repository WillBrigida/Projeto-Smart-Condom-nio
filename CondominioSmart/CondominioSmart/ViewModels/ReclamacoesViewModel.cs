using CondominioSmart.DataBase;
using CondominioSmart.Infrastructure;
using CondominioSmart.Models;
using CondominioSmart.Services;
using CondominioSmart.Views.PopUps;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
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
        private readonly ReclamacaoRepository _reclamacaoRepository;
        private readonly RealmRepository<Reclamacao>_realmRepository;
        #endregion

        #region Commands
        public ICommand AddCommand { get { return new Command(OnAddExecute); } }

        #endregion

        #region Construtor
        public ReclamacoesViewModel()
        {
            _realmRepository = new RealmRepository<Reclamacao>();
            _reclamacaoRepository = new ReclamacaoRepository();

        }
        #endregion

        #region Métodos

        private void OnAddExecute(object obj)
        {
            if (!String.IsNullOrWhiteSpace(TitleReclamacao))
            {
                MessagingCenter.Send(new Reclamacao
                { TextReclamacao = this.TextReclamacao, TitleReclamacao = this.TitleReclamacao}, "Confirmacao");

                //Ao ser clicado o botão, é disparado um comando para todos que estão
                //ouvindo a classe. E é nos ouvintes que são implementado as ações.
                //Os ouvintes são definidos através de uma assinatura que nesse caso é a string "Confirmacao".
            }
        }
        #endregion
    }
}

