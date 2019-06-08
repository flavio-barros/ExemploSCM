using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

using ExemploSCM.Models;

namespace ExemploSCM.Dao
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            string connectionString = @"Data Source=App_Data\mstar.db";
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.ConnectionString(connectionString))
                .Mappings(m =>
                            m.FluentMappings
                                .AddFromAssemblyOf<Mercadoria>()
                                .AddFromAssemblyOf<Entrada>()
                                .AddFromAssemblyOf<Saida>())
                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}