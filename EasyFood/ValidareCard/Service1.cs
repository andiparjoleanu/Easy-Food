using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace ValidareCard
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Validare: CheckCard
    {
        public bool valideaza(string numar, string cvv,  string dataExpirare)
        {

            if (numar.Length != 12) return false;

            if (cvv.Length < 3 || cvv.Length > 4) return false;

            string currentMonth = DateTime.Now.Month.ToString();
            string currentYear = DateTime.Now.Year.ToString();
            string date = currentMonth+'/'+currentYear;

            

            if (dataExpirare.CompareTo(date) > 0 )  return false;

            int sum = 0;
            bool doubled = true;

            foreach ( char c in numar)
            {
                int cifra;

                if (!int.TryParse(c.ToString(), out cifra))
                {
                    return false;
                }

                if (doubled) cifra *= 2;

                if (cifra > 9) cifra = cifra % 10 + cifra / 10;

                sum += cifra;

                doubled = !doubled;
            }

            if (sum % 10 != 0) return false;

            return true;
        }

        
    }

    
    
}


