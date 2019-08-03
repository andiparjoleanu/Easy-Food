using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EasyFood.Models
{
    public class Reteta
    {
        public int RetetaID { get; set; }

        [Required]
        public string Denumire { get; set; }

        [Required]
        public string Descriere { get; set; }

        [Required]
        public int Stoc { get; set; }

        [Required]
        public float Pret { get; set; }

        [Required]
        [Display(Name = "Imagine Prezentare")]
        public string LinkImaginePrezentare { get; set; }
        
        [Required]
        [Display(Name = "Nivel de dificultate")]
        public int NivelDificultate { get; set; }


        [Required]
        [Display(Name = "Timp de preparare")]
        public int TimpPreparare { get; set; }

        [Required]
        public string Categorie { get; set; }

        public string LinkVideo { get; set; }

        public virtual Bucatar Bucatar { get; set; }
        public virtual ICollection<Comanda> Comenzi { get; set; }
        public virtual ICollection<Ingredient> Ingrediente { get; set; }
    }
}