using CondominioSmart.Helpers;
using CondominioSmart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CondominioSmart.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : MasterDetailPage
	{
        //private MenuViewModel ViewModel => BindingContext as MenuViewModel;
        public string Icon { get; set; }


        public MenuPage ()
		{
			InitializeComponent ();

            Icon = FontAwesome.Film;

            Detail = new NavigationPage(new PortariaPage());

            int contador = 0;
            if (contador == 0)
            {
                Detail.Navigation.PushModalAsync(new LoginPage());
                contador += 1;
            }
            //Detail = new PortariaPage();
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await ViewModel.LoadAsync();
        //}
        private void GoPage1(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new ReclamacaoTabbedPage());
            IsPresented = false;
        }

        private void GoPage2(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new InformacoesPage());
            IsPresented = false;
        }

        private void GoPage3(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new PopsPage());
            IsPresented = false;
        }

        private void GoPage4(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new AtendimentosPage());
            IsPresented = false;
        }

        private void GoPage5(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushModalAsync(new ScannerPage());
            IsPresented = false;
        }

        private void GoPage6(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushModalAsync(new ScannerPage());
            IsPresented = false;
        }

    }
}