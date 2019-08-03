using System;
using System.ServiceModel;

namespace ValoriNutritionale
{
    public class CalculatorService : ICalculator
    {
        public IngredientReteta AdunaIngrediente(IngredientReteta[] arr)
        {
            IngredientReteta valReteta = new IngredientReteta();
            for (int i = 0; i < arr.Length; i++)
            {
                valReteta.Calorii += arr[i].Calorii;
                valReteta.Proteine += arr[i].Proteine;
                valReteta.Carbohidrati += arr[i].Carbohidrati;
                valReteta.Grasimi += arr[i].Grasimi;
            }
            return valReteta;
        }

        public IngredientReteta ImparteIngredient(IngredientReteta ingr, double nrGrame)
        {
            IngredientReteta i = new IngredientReteta();
            i.Calorii = Math.Ceiling((ingr.Calorii * nrGrame) / 100.0);
            i.Carbohidrati = Math.Ceiling((ingr.Carbohidrati * nrGrame) / 100.0);
            i.Grasimi = Math.Ceiling((ingr.Grasimi * nrGrame) / 100.0);
            i.Proteine = Math.Ceiling((ingr.Proteine * nrGrame) / 100.0);
            return i;
        }
    }
}