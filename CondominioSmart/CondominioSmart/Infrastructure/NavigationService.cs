using CondominioSmart.Services;
using CondominioSmart.ViewModels;
using CondominioSmart.Views;
using CondominioSmart.Views.PopUps;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CondominioSmart.Infrastructure
{
    public class NavigationService : INavigationService
    {
        public async Task NavigationForLogin()
        {
            MainViewModel.GetInstance().Login = new LoginViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
        }

        public async Task NavigationForMenu()
        {
            MainViewModel.GetInstance().Menu = new MenuViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new MenuPage());
        }

        public async Task NavigationForPopUpCheckOk()
        {
            await PopupNavigation.PushAsync(new PopUpCheckOk());
        }

        public async Task NavigationForPopUpLoadPage()
        {
            await PopupNavigation.PushAsync(new PopUpLoadPage());
        }

        public async Task NavigationForPopUpPage()
        {
            await PopupNavigation.PushAsync(new PopUpPage());
        }

        public async Task NavigationForPopUpLoadPage(string titulo, string mensagem)
        {
            await PopupNavigation.PushAsync(new PopUpLoadPage());
        }

        public async Task NavigationForReclamacoesPage()
        {
            MainViewModel.GetInstance().Reclamacoes = new ReclamacoesViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new ReclamacoesPage());
        }

        public async Task NavigationForInformacoesPage()
        {
            MainViewModel.GetInstance().Informacoes = new InformacoesViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new InformacoesPage());
        }

        public async Task NavigationForPopPage()
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }

        public async Task NavigationForAtendimentosPage()
        {
            MainViewModel.GetInstance().Atendimentos = new AtendimentosViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new AtendimentosPage());
        }

        public async Task NavigationForPortariaPage()
        {
            MainViewModel.GetInstance().Portaria = new PortariaViewModel();
            await App.Current.MainPage.Navigation.PushAsync(new PortariaPage());
        }

        public async Task NavigationForReclamacaoTabbedPagePage()
        {
            await App.Current.MainPage.Navigation.PushAsync(new ReclamacaoTabbedPage());

        }
    }
}
