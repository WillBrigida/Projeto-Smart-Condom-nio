using CondominioSmart.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CondominioSmart.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReclamacaoTabbedPage : TabbedPage
    {
        private ReclamacaoTabbedViewModel ViewModel => BindingContext as ReclamacaoTabbedViewModel;

        public ReclamacaoTabbedPage ()
        {
            InitializeComponent();
            //this.BindingContext = new ReclamacaoTabbedViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadAsync();
        }
    }
}