using System;
using System.ServiceModel;

namespace ValoriNutritionale
{
    
    public class IngredientReteta
    {
        public double Carbohidrati;
        public double Grasimi;
        public double Proteine;
        public double Calorii;

        public IngredientReteta()
        {

        }
    }

    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface ICalculator
    {
        [OperationContract]
        IngredientReteta AdunaIngrediente(IngredientReteta[] arr);

        [OperationContract]
        IngredientReteta ImparteIngredient(IngredientReteta ingr, double nrGrame);
    }
}