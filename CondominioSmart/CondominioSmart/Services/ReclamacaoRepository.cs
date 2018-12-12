using CondominioSmart.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CondominioSmart.Services
{
    class ReclamacaoRepository : IReclamacaoRepository
    {
        protected Realm RealmDb;

        public ReclamacaoRepository()
        {
            RealmDb = Realm.GetInstance();
        }

        public void Delete(Reclamacao reclamacao)
        {
            var reclamacaoData = RealmDb.Find<Reclamacao>(reclamacao.ReclamacaoId);

            RealmDb.Write(() => RealmDb.Remove(reclamacaoData));
        }

        public void DeleteAll()
        {
            RealmDb.Write(() => RealmDb.RemoveAll());
        }

        public Reclamacao Get(int id)
        {
            return RealmDb.Find<Reclamacao>(id);
        }

        public List<Reclamacao> GetAll()
        {
            return RealmDb.All<Reclamacao>().ToList();
        }

        public void Insert(Reclamacao reclamacao)
        {
            var reclamacoes = RealmDb.All<Reclamacao>().ToList();
            var maxNotaId = 0;

            if (reclamacoes.Count != 0)
            {
                maxNotaId = reclamacoes.Max(r => r.ReclamacaoId);
            }

            reclamacao.ReclamacaoId = maxNotaId + 1;

            RealmDb.Write(() => reclamacao = RealmDb.Add(reclamacao));
        }

        public void UpDate(Reclamacao reclamacao)
        {
            var reclamacaoData = RealmDb.Find<Reclamacao>(reclamacao.ReclamacaoId);

            RealmDb.Write(() =>
            {
                reclamacaoData.TitleReclamacao = reclamacao.TitleReclamacao;
                reclamacaoData.TextReclamacao = reclamacao.TextReclamacao;
                RealmDb.Add(reclamacaoData, true);
            });
        }
    }
}
