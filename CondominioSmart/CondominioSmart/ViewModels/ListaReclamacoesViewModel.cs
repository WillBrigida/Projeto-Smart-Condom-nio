using CondominioSmart.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace CondominioSmart.ViewModels
{
    public class ListaReclamacoesViewModel : BaseViewModel
    {
        private ObservableCollection<Message> _listaItem;

        public ObservableCollection<Message> ListaItem
        {
            get { return _listaItem; }
            set { SetProperty(ref _listaItem, value); }
        }

        public ListaReclamacoesViewModel()
        {
            ListaItem = new ObservableCollection<Message>();
            AdicionarLista();
        }

        private void AdicionarLista()
        {
            MessagingCenter.Subscribe<Message>(this, "Confirmacao", message =>
            {
                ListaItem.Add(message);
            });
        }
    }
}

