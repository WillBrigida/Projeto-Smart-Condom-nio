using System;
using System.Collections.Generic;
using System.Text;

namespace CondominioSmart.MassaDeDados
{

    public class Condominos
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Apartamento { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return Nome + " " + SobreNome;
        }
    }

    






    public class Massa
    {
        public List<Condominos> ListaCondominos { get; set; }


        public Massa()
        {
            ListaCondominos = new List<Condominos>();
        }

        public List<Condominos> Lista()
        {
            ListaCondominos = new List<Condominos>
           {
              new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
               new Condominos{Nome = "Marcio", SobreNome = "da Silva José", Apartamento = "101", Telefone = "981565477"},
              new Condominos{Nome = "Will", SobreNome = "Brigida", Apartamento = "102", Telefone = "22526466"},
              new Condominos{Nome = "José", SobreNome = "Moreira Carvalho da Silva Rodrigues", Apartamento = "201", Telefone = "956554123"},
              new Condominos{Nome = "Paula", SobreNome = "Czal fernandes", Apartamento = "202", Telefone = "21258566"},
              new Condominos{Nome = "Tenório", SobreNome = "Vilela", Apartamento = "301", Telefone = "56552145"},
              new Condominos{Nome = "Samuel", SobreNome = "Heloísa Ferreira", Apartamento = "302", Telefone = "25587469"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},

              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},
              new Condominos{Nome = "Eduardo", SobreNome = "Barreto Eduardo", Apartamento = "401", Telefone = "35224981"},

           };
            return ListaCondominos;
        }
    }

}
