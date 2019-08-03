using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EasyFood.Models
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public int RetetaID { get; set; }
        public int ProdusID { get; set; }

        public int Cantitate { get; set; }
        

        public virtual Produs Produs { get; set; }
        public virtual Reteta Reteta { get; set; }
    }
}