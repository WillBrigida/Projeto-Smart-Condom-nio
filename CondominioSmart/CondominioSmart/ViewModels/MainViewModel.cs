
namespace CondominioSmart.ViewModels
{
    public class MainViewModel
    {
        //  classe navegação

        #region Propriedade
        public LoginViewModel Login { get; set; }
        public MenuViewModel Menu { get; set; }
        public ReclamacoesViewModel Reclamacoes { get; set; }
        public InformacoesViewModel Informacoes { get; set; }
        public AtendimentosViewModel Atendimentos { get; set; }
        public PortariaViewModel Portaria { get; set; }
        #endregion

        #region Construtor
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();

        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}

