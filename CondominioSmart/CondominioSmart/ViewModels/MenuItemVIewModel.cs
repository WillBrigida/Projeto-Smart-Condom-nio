using CondominioSmart.Services;
using CondominioSmart.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class MenuItemViewModel
    {
        public string Icon { get; set; }
        public string Titulo { get; set; }

        public MenuItemViewModel(string icon, string titulo)
        {
            this.Icon = icon;
            this.Titulo = titulo;

        }
       
    }
}
