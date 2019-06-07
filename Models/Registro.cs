using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploSCM.Models
{
    public class Registro
    {
        public virtual int Id { get; set; }

        [Display(Name = "Mercadoria")]
        [Required]
        public virtual Mercadoria Mercadoria { get; set; }

        [Display(Name = "Quantidade")]
        public virtual int Quantidade { get; set; } 

        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public virtual DateTime Data { get; set; }

        [Display(Name = "Hora")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{HH:mm}", ApplyFormatInEditMode = true)]
        public virtual DateTime Hora { get; set; }

        [Display(Name = "Local")]
        public virtual string Local { get; set; }
    }
}