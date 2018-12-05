using CondominioSmart.ViewModels.PopUpViewModels;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CondominioSmart.Views.PopUps
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpPage : PopupPage
    {
        public PopUpPage()
        {
            InitializeComponent();
            this.BindingContext = new PopUpViewModel();
        }
    }
}