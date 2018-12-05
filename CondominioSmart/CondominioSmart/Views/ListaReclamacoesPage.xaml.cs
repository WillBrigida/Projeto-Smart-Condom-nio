using CondominioSmart.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CondominioSmart.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaReclamacoesPage : ContentPage
	{
		public ListaReclamacoesPage ()
		{
			InitializeComponent ();
            this.BindingContext = new ListaRecamacoesViewModel();
		}
	}
}