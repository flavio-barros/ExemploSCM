using System.Collections.Generic;
using System.Linq;
using NHibernate;

namespace ExemploSCM.Dao
{
    public class SaidaRepository<Saida> : IRepository<Saida>
    {
        public void Remover(Saida saida)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Delete(saida);
                transaction.Commit();
            }
        }

        public Saida Recuperar(int id)
        {
            using (ISession session = NHibernateHelper.OpenSession())
                return session.Get<Saida>(id);
        }

        public List<Saida> Listar()
        {
            using (ISession session = NHibernateHelper.OpenSession())
            {
                return session.Query<Saida>().ToList();
            }
        }

        public void Salvar(Saida saida)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(saida);
                transaction.Commit();
            }
        }

        public void Editar(Saida saida)
        {
            using (ISession session = NHibernateHelper.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Update(saida);
                transaction.Commit();
            }
        }
    }
}