using CondominioSmart.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class DetalheViewModel : BaseViewModel
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

        #endregion

        #region Commands

        #endregion

        #region Construtor
        public DetalheViewModel(Reclamacao reclamacao)
        {
            this.TextReclamacao = reclamacao.TextReclamacao;
            this.TitleReclamacao = reclamacao.TitleReclamacao;
        }
        #endregion

        #region Métodos

        

        #endregion
    }
}
