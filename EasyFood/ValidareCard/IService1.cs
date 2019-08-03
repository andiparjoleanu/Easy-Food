using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ValidareCard
{
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    public interface CheckCard
    {
        [OperationContract]
        bool valideaza(string numarCard, string cvv, string dataExpirare);
      
    }
}
