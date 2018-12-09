﻿using CondominioSmart.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CondominioSmart.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaReclamacoesPage : ContentPage
	{
        //ListaReclamacoesViewModel ViewModel => BindingContext as ListaReclamacoesViewModel;
		public ListaReclamacoesPage ()
		{
			InitializeComponent ();
            this.BindingContext = new ListaReclamacoesViewModel();
		}

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //    await ViewModel.LoadAsync();
        //}
    }
}