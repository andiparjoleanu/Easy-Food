using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EasyFood.Models
{
    public class Produs
    {
        public int ID { get; set; }

        [Required]
        public string Denumire { get; set; }

        [Required]
        public string Furnizor { get; set; }

        [Required]
        public float Stoc { get; set; }

        [Required]
        public int Carbohidrati { get; set; }

        [Required]
        public int Proteine { get; set; }

        [Required]
        public int Grasimi { get; set; }

        [Required]
        public int Calorii { get; set; }

        [Required]
        [Display(Name = "Unitate de masura")]
        public string UnitateMasura { get; set; }
    }
}