using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CondominioSmart.Models
{
    public class Reclamacao : RealmObject
    {
        [PrimaryKey]
        public int ReclamacaoId { get; set; }
        public string TitleReclamacao { get; set; }
        public string TextReclamacao { get; set; }
    }
}
