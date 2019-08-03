using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Models
{
    public class Comanda
    {
        public int ComandaID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Dată comandă")]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataComanda { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Dată livrare")]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataLivrare { get; set; }

        [Required]
        [Display(Name = "Modalitate de plată")]
        //[RegularExpression(@"Cash|Card")]
        public string ModalitatePlata { get; set; }

        public virtual Client Client { get; set; }
        public virtual ICollection<Reteta> Retete { get; set; }
    }
}