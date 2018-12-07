using CondominioSmart.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CondominioSmart.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaReclamacoesPage : ContentPage
	{
        ListaRecamacoesViewModel ViewModel => BindingContext as ListaRecamacoesViewModel;
		public ListaReclamacoesPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadAsync();
        }
    }
}