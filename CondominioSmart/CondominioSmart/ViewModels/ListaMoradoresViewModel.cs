using CondominioSmart.Models;
using CondominioSmart.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                FiltrarListaMoradores();
            }

        }

        private ObservableCollection<Moradores> _listaMoradores;

        public ObservableCollection<Moradores> ListaMoradores
        {
            get { return _listaMoradores; }
            set {SetProperty(ref _listaMoradores , value); }
        }

        public ObservableCollection<Moradores> _listaMoradoresFiltrada { get; set; }
        private ApiService apiService;

        #endregion

        #region Commands
        public ListaMoradoresViewModel()
        {
            apiService = new ApiService();
            ListaMoradores = new ObservableCollection<Moradores>();
            _listaMoradoresFiltrada = new ObservableCollection<Moradores>();
            LoadMoradores();
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
              //  new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              //new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              //new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              //new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              //new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              //new CondominosFakes{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              //new CondominosFakes{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
              // new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              //new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              //new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              //new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              //new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              // new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              //new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              //new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              //new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              //new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              //new CondominosFakes{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              //new CondominosFakes{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
              // new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              //new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              //new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              //new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              // new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              //new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              //new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              //new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              //new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              //new CondominosFakes{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              //new CondominosFakes{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
              // new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              //new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              //new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              //new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              // new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              //new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              //new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              //new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              //new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              //new CondominosFakes{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              //new CondominosFakes{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
              // new CondominosFakes{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              //new CondominosFakes{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              //new CondominosFakes{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              //new CondominosFakes{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              //new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              //new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              //new CondominosFakes{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},

                #endregion
            };
            return lista;
        }

       

        //passo 1 - chamada da lista 
        private async void LoadMoradores()
        {
            this.IsRunning = true;
            var moradores = await apiService.Get<Moradores>("http://estudoazure02.azurewebsites.net", "/api", "/Moradores");
            ConverterMoradores(moradores);
            this.IsRunning = false;
        }

        //passo 2 - Converte uma list para uma observable
        private void ConverterMoradores(List<Moradores> moradores)
        {
            ListaMoradores.Clear();
            foreach (var morador in moradores)
            {
                ListaMoradores.Add(new Moradores
                {
                    ApartamentoMorador = morador.ApartamentoMorador,
                    IdMorador = morador.IdMorador,
                    NomeMorador = morador.NomeMorador,
                    Sescricao = morador.Sescricao,
                    TelefoneMorador = morador.TelefoneMorador,
                });
            }
        }


        private void FiltrarListaMoradores()
        {
            if (string.IsNullOrEmpty(Filtro))
            {
                ListaMoradores = new ObservableCollection<Moradores>(_listaMoradoresFiltrada);
            }
            else
            {
                ListaMoradores = new ObservableCollection<Moradores>
                     (_listaMoradoresFiltrada.Where(p => p.NomeMorador.ToLower().Contains(Filtro.ToLower()) ||
                      p.ApartamentoMorador.ToLower().Contains(Filtro.ToLower())));
            }
        }

        #endregion
    }
}
