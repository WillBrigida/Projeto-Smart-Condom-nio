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
	public partial class ReclamacoesPage : ContentPage
	{
        //private ReclamacoesViewModel ViewModel => BindingContext as ReclamacoesViewModel;

        public ReclamacoesPage ()
		{
			InitializeComponent ();
            this.BindingContext = new ReclamacoesViewModel();
		}

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await ViewModel.LoadAsync();
        //}
    }
}