using CondominioSmart.DataBase;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CondominioSmart.Models
{
    public class Reclamacao : RealmObject, IEntity
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string TitleReclamacao { get; set; }
        public string TextReclamacao { get; set; }
    }
}
