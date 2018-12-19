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
    public partial class PortariaPage : ContentPage
    {
        // private PortariaViewModel ViewModel => BindingContext as PortariaViewModel;

        public PortariaPage()
        {
            InitializeComponent();
            BindingContext = new PortariaViewModel();

        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await ViewModel.LoadAsync();
        //}
    }
}