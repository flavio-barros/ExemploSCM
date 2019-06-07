using FluentNHibernate.Mapping;

using ExemploSCM.Models;

namespace ExemploSCM.Map
{
    // Classe de mapeamento da classe Entrada (Model)
    public class EntradaMap : ClassMap<Entrada>
    {
        public EntradaMap()
        {
            Id(x => x.Id);
            References(x => x.Mercadoria).Not.LazyLoad();
            Map(x => x.Quantidade);
            Map(x => x.Data);
            Map(x => x.Hora);
            Map(x => x.Local);
            Table("Entrada");
        }
    }
}