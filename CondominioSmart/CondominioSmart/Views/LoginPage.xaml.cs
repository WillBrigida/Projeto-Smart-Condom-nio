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
	public partial class LoginPage : ContentPage
	{
        //private LoginViewModel ViewModel => BindingContext as LoginViewModel;

        private bool _teste;

        public bool Teste
        {
            get { return _teste; }
            set { _teste = value; }
        }

        private bool _isVisible2;

        public bool IsVisible2
        {
            get { return _isVisible2; }
            set { _isVisible2 = value; }
        }


        public LoginPage ()
		{
            Teste = false;
			InitializeComponent ();
            this.BindingContext = new LoginViewModel();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
  

            // Waiting some time
            await Task.Delay(500);

            // Start animation  
            await Task.WhenAll(
                //SplashGrid.FadeTo(0, 200),
                Logo.ScaleTo(0.6, 300, Easing.SpringIn),
                Logo.TranslateTo(0, -150, 300)
                );

            this.Teste = true;
            this.IsVisible2 = false;
        }
    }
}