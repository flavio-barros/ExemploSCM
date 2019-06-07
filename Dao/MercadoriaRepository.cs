using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;

namespace ExemploSCM.Dao
{
    public class MercadoriaRepository<Mercadoria> : IRepository<Mercadoria>
    {
        public void Remover(Mercadoria mercadoria)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(mercadoria);
                transaction.Commit();
            }
        }

        public Mercadoria Recuperar(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Mercadoria>(id);
        }

        public List<Mercadoria> Listar()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Mercadoria>().ToList();
            }
        }

        public void Salvar(Mercadoria mercadoria)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(mercadoria);
                transaction.Commit();
            }
        }

        public void Editar(Mercadoria mercadoria)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(mercadoria);
                transaction.Commit();
            }
        }
    }
}