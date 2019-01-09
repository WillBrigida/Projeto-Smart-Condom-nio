using CondominioSmart.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CondominioSmart.Services
{
    public class NavService
    {
        public async Task Navigate( string pageName)
        {

            App._menu.IsPresented = false;
            var mdp = (Application.Current.MainPage as MasterDetailPage);
            var navPage = mdp.Detail as NavigationPage;
            switch (pageName)


            {
                case "PortariaPage":
                    await navPage.PushAsync(new PortariaPage());
                    break;
                case "ReclamacaoTabbedPage":
                    await navPage.PushAsync(new ReclamacaoTabbedPage());
                    break;
                case "InformacoesPage":
                    await navPage.PushAsync(new InformacoesPage());
                    break;
                case "AtendimentosPage":
                    await navPage.PushAsync(new AtendimentosPage());
                    break;
                case "ScannerPage":
                    await navPage.PushAsync(new ScannerPage());
                    break;
                case "LoginPage":
                    await navPage.PushAsync(new LoginPage());
                    break;
            }

        }
    }
}
