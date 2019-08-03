using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EasyFood.ServiceReference2;
using EasyFood.Models;

namespace EasyFood.ViewModels
{
    public class ValoareNutritionalaReteta
    {
        public CalculatorClient CalculatorClient;
        public Reteta Reteta;

        public ValoareNutritionalaReteta(Reteta Reteta)
        {
            CalculatorClient = new CalculatorClient();
            this.Reteta = Reteta;
        }
    }
}