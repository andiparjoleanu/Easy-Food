using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EasyFood.Models
{
    public class Bucatar
    {
        [Key]
        [ForeignKey("Angajat")]
        public int AngajatID { get; set; }

        [Required]
        public string Pregatire { get; set; }

        [Required]
        public string Specializare { get; set; }

        [Required]
        public float Rating { get; set; }

        [Required]
        public string LinkPoza { get; set; }

        public virtual ICollection<Reteta> Retete { get; set; }
        public virtual Angajat Angajat { get; set; }
    }
}