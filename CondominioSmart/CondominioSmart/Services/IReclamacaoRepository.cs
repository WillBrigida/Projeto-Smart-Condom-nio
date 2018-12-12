using CondominioSmart.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CondominioSmart.Services
{
     interface IReclamacaoRepository
    {
        List<Reclamacao> GetAll();
        Reclamacao Get(int id);
        void Insert(Reclamacao reclamacao);
        void UpDate(Reclamacao reclamacao);
        void DeleteAll();
        void Delete(Reclamacao reclamacao);
    }
}
