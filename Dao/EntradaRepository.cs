using System.Collections.Generic;
using System.Linq;
using NHibernate;

namespace ExemploSCM.Dao
{
    public class EntradaRepository<Entrada> : IRepository<Entrada>
    {
        public void Remover(Entrada entrada)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(entrada);
                transaction.Commit();
            }
        }

        public Entrada Recuperar(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Entrada>(id);
        }

        public List<Entrada> Listar()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Entrada>().ToList();
            }
        }

        public void Salvar(Entrada entrada)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(entrada);
                transaction.Commit();
            }
        }

        public void Editar(Entrada entrada)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(entrada);
                transaction.Commit();
            }
        }
    }
}