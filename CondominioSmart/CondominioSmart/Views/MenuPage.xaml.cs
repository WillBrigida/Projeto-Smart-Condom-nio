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
        private MenuViewModel ViewModel => BindingContext as MenuViewModel;


        public MenuPage()
        {
            InitializeComponent();
            this.BindingContext = new MenuViewModel();


            Detail = new NavigationPage(new PortariaPage());


            Detail.Navigation.PushModalAsync(new LoginPage());
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadAsync();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                ViewModel.NavigationCommand.Execute(e.SelectedItem);
            }
        }

    }
}