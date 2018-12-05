using CondominioSmart.ViewModels;

namespace CondominioSmart.Infrastructure
{
    public class InstanceLocator
    {
        #region Propriedade
        public MainViewModel Main { get; set; }
        #endregion

        #region Construtor
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
