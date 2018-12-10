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
	public partial class ListaBuscaPage : ContentPage
	{
		public ListaBuscaPage ()
		{
			InitializeComponent ();
            this.BindingContext = new ListaBuscaViewModel();

        }
    }
}