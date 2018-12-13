using CondominioSmart.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CondominioSmart.ViewModels
{
    public class ListaMoradoresViewModel : BaseViewModel
    {
        #region Propriedade
        private string filtro;

        public string Filtro
        {
            get { return filtro; }
            set
            {
                this.SetProperty(ref filtro, value);
                Search();
            }

        }

        private ObservableCollection<CondominosFakes> _listaCondominos;

        public ObservableCollection<CondominosFakes> ListaCondominos
        {
            get { return _listaCondominos; }
            set {SetProperty(ref _listaCondominos , value); }
        }

        public ObservableCollection<CondominosFakes> _listaCondominosFiltrada { get; set; }

        #endregion

        #region Commands
        public ListaMoradoresViewModel()
        {
            ListaCondominos = new ObservableCollection<CondominosFakes>(Lista());
            _listaCondominosFiltrada = new ObservableCollection<CondominosFakes>(Lista());
        }
        #endregion

        #region Construtor

        #endregion

        #region Métodos
        public List<CondominosFakes> Lista()
        {
            var lista = new List<CondominosFakes>()
            {
                #region listaFake
                new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new CondominosFakes{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new CondominosFakes{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
               new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new CondominosFakes{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new CondominosFakes{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
               new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new CondominosFakes{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new CondominosFakes{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
               new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new CondominosFakes{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new CondominosFakes{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},

                #endregion
            };
            return lista;
        }

        private void Search()
        {
            if (string.IsNullOrEmpty(Filtro))
            {
                ListaCondominos = new ObservableCollection<CondominosFakes>(_listaCondominosFiltrada);
            }
            else
            {
                ListaCondominos = new ObservableCollection<CondominosFakes>
                     (_listaCondominosFiltrada.Where(p => p.Nome.ToLower().Contains(Filtro.ToLower()) ||
                      p.Apartamento.ToLower().Contains(Filtro.ToLower())));
            }
        }
        #endregion
    }
}
