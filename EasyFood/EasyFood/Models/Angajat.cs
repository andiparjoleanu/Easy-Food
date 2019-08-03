using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyFood.Models
{
    public class Angajat
    {
        public int ID { get; set; }

        [Required]
        public string Nume { get; set; }

        [Required]
        public string Prenume { get; set; }

        public virtual Bucatar Bucatar { get; set; }
        public virtual Administrator Administrator { get; set; }
    }

}