using CondominioSmart.ViewModels.PopUpViewModels;
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
    public partial class PopUpLoadPage
    {
        public PopUpLoadPage()
        {
            InitializeComponent();
            this.BindingContext = new PopUpLoadViewModel();
        }
    }
}