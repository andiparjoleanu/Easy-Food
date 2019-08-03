using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyFood.Models
{
    public class Administrator
    {
        [Key]
        [ForeignKey("Angajat")]
        public int AngajatID { get; set; }

        [Required]
        public string NumeUtilizator { get; set; }

        [Required]
        public string Parola { get; set; }

        public virtual Angajat Angajat { get; set; }
    }
}