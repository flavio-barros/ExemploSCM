using FluentNHibernate.Mapping;
using ExemploSCM.Models;

namespace ExemploSCM.Map
{
    // Classe de mapeamento da classe Mercadoria (Model)
    public class MercadoriaMap : ClassMap<Mercadoria>
    {
        public MercadoriaMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Numero_registro);
            Map(x => x.Fabricante);
            Map(x => x.Tipo);
            Map(x => x.Descricao);
            Table("Mercadoria");
        }
    }
}