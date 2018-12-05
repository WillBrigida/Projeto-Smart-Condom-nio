using CondominioSmart.Services;
using CondominioSmart.Views.PopUps;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels.PopUpViewModels
{
    public class PopUpLoadViewModel : BaseViewModel
    {
        #region Propriedade
        private readonly INavigationService _navigationService;
        private readonly IMessegeService _messegeService;
        static string m;
        static string t;

        private string _titulo;
        private string _mensagem;

        public string Titulo
        {
            get { return _titulo; }
            set { SetProperty(ref _titulo, value); }
        }


        public string Mensagem
        {
            get { return _mensagem; }
            set { SetProperty(ref _mensagem, value); }
        }

       
        #endregion

        #region Commands

        #endregion

        #region Construtor
        public PopUpLoadViewModel()
        {
            _navigationService = DependencyService.Get<INavigationService>();
            Titulo = "Por favor, aguarde!";
            Mensagem = "Carregando";
        }
        #endregion

        #region Métodos
        //public async Task Load(bool load)
        //{
        //    this.IsVisible = true;

        //    if (load == true)
        //    {
        //        t = "por favor, aguarde";
        //        m = "carregando . . .";
        //        await _navigationService.NavigationForPopUpLoadPage(true, t, m);
        //        return;
        //    }
        //     await PopupNavigation.PopAsync();
        //}

        public async Task PopUpMensagem(string titulo, string mensagem)
        {
            titulo = "Este";
            mensagem = "fdljladk";
            await _navigationService.NavigationForPopUpLoadPage(titulo, mensagem);
        }

        
        #endregion




        //static string m;
        //static string t;

        //private string _titulo;
        //private string _mensagem;

        //public string Titulo
        //{
        //    get { return _titulo; }
        //    set { SetProperty(ref _titulo, value); }
        //}


        //public string Mensagem
        //{
        //    get { return _mensagem; }
        //    set { SetProperty(ref _mensagem, value); }
        //}

        //public PopUpLoadViewModel()
        //{
        //    IsVisible = true;
        //    Mensagem = m;
        //    Titulo = t;
        //}



        //private static PopUpLoadViewModel instance;
        //public static PopUpLoadViewModel GetInstance()
        //{
        //    if (instance == null)
        //    {
        //        return new PopUpLoadViewModel();
        //    }
        //    return instance;
        //}

        //public async Task Load(bool load, string titulo, string mensagem)
        //{
        //    IsVisible = true;

        //    if (load == true)
        //    {
        //        t = titulo;
        //        m = mensagem;
        //        await PopupNavigation.PushAsync(new PopUpLoadPage());
        //        return;
        //    }
        //    await PopupNavigation.PopAsync();
        //}

        //public async Task Load(bool load)
        //{
        //    IsVisible = true;

        //    if (load == true)
        //    {
        //        t = "Por favor, aguarde";
        //        m = "Carregando . . .";
        //        await PopupNavigation.PushAsync(new PopUpLoadPage());
        //        return;
        //    }
        //    await PopupNavigation.PopAsync();
        //}


        //public async Task Load()
        //{
        //    IsVisible = false;
        //    m = "Carregando . . .";
        //    await PopupNavigation.PushAsync(new PopUpLoadPage());
        //    IsVisible = true;
        //    return;

        //}
    }
}