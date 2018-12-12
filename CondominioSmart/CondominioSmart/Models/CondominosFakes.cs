using System;
using System.Collections.Generic;
using System.Text;

namespace CondominioSmart.Models
{
    public class CondominosFakes
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
}
