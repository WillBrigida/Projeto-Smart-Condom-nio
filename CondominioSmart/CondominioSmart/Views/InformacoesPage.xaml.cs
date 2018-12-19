﻿using CondominioSmart.ViewModels;
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
	public partial class InformacoesPage : ContentPage
	{
        //private InformacoesViewModel ViewModel => BindingContext as InformacoesViewModel;

        public InformacoesPage ()
		{
			InitializeComponent ();
            BindingContext = new  InformacoesViewModel();
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await ViewModel.LoadAsync();
        //}
    }
}