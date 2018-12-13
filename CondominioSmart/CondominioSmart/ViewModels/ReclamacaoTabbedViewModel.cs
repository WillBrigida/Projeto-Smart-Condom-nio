using CondominioSmart.Models;
using CondominioSmart.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ReclamacaoTabbedViewModel : BaseViewModel
    {
        #region Propriedade
        private int _contador;

        public int Contador
        {
            get { return _contador; }
            set { SetProperty(ref _contador, value); }
        }

        private readonly IReclamacaoRepository _reclamacaoRepository;

        #endregion

        #region Commands

        #endregion

        #region Construtor
        public ReclamacaoTabbedViewModel()
        {
            _reclamacaoRepository = new ReclamacaoRepository();
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
            Contador = _reclamacaoRepository.GetAll().Count;
        }
        #endregion
    }
}
