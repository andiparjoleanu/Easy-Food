﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyFood.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="ServiceReference1.CheckCard")]
    public interface CheckCard {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/CheckCard/valideaza", ReplyAction="http://Microsoft.ServiceModel.Samples/CheckCard/valideazaResponse")]
        bool valideaza(string numarCard, string cvv, string dataExpirare);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/CheckCard/valideaza", ReplyAction="http://Microsoft.ServiceModel.Samples/CheckCard/valideazaResponse")]
        System.Threading.Tasks.Task<bool> valideazaAsync(string numarCard, string cvv, string dataExpirare);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CheckCardChannel : EasyFood.ServiceReference1.CheckCard, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CheckCardClient : System.ServiceModel.ClientBase<EasyFood.ServiceReference1.CheckCard>, EasyFood.ServiceReference1.CheckCard {
        
        public CheckCardClient() {
        }
        
        public CheckCardClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CheckCardClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckCardClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CheckCardClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool valideaza(string numarCard, string cvv, string dataExpirare) {
            return base.Channel.valideaza(numarCard, cvv, dataExpirare);
        }
        
        public System.Threading.Tasks.Task<bool> valideazaAsync(string numarCard, string cvv, string dataExpirare) {
            return base.Channel.valideazaAsync(numarCard, cvv, dataExpirare);
        }
    }
}
