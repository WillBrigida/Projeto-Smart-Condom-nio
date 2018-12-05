using CondominioSmart.Infrastructure;
using CondominioSmart.Services;
using CondominioSmart.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CondominioSmart
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<INavigationService, NavigationService>();
            DependencyService.Register<IMessegeService, MessegeService>();

            //Versionamento do esquema do RealmDB
            //Realms.RealmConfiguration.DefaultConfiguration.SchemaVersion = 1;

            LiveReload.Init();

            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private bool ValidacaoLogin()
        {
            if (true)
            {
                return true;
            }
        }
    }
}
