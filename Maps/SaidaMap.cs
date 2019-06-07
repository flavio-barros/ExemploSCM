using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using ExemploSCM.Models;

namespace ExemploSCM.Map
{
    public class SaidaMap : ClassMap<Saida>
    {
        public SaidaMap()
        {
            Id(x => x.Id);
            References(x => x.Mercadoria).Not.LazyLoad(); ;
            Map(x => x.Quantidade);
            Map(x => x.Data);
            Map(x => x.Hora);
            Map(x => x.Local);
            Table("Saida");
        }
    }
}