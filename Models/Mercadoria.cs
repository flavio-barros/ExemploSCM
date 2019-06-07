using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System.ComponentModel.DataAnnotations;

namespace ExemploSCM.Models
{
    public class Mercadoria
    {
        public virtual int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(100)]
        public virtual string Nome { get; set; }

        [Required]
        [Display(Name = "Número de registro")]
        public virtual int Numero_registro { get; set; }

        [Required]
        [Display(Name = "Fabricante")]
        [StringLength(50)]
        public virtual string Fabricante { get; set; }

        [Required]
        [Display(Name = "Tipo")]
        [StringLength(20)]
        public virtual string Tipo { get; set; }

        [Display(Name = "Descrição")]
        public virtual string Descricao { get; set; }
    }
}