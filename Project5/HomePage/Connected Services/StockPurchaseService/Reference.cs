﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginTryIt.StockPurchaseService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StockPurchaseService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/purchaseStock", ReplyAction="http://tempuri.org/IService1/purchaseStockResponse")]
        int purchaseStock(string stockSymbol, string quantity, string cardNo, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/purchaseStock", ReplyAction="http://tempuri.org/IService1/purchaseStockResponse")]
        System.Threading.Tasks.Task<int> purchaseStockAsync(string stockSymbol, string quantity, string cardNo, string user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : LoginTryIt.StockPurchaseService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<LoginTryIt.StockPurchaseService.IService1>, LoginTryIt.StockPurchaseService.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int purchaseStock(string stockSymbol, string quantity, string cardNo, string user) {
            return base.Channel.purchaseStock(stockSymbol, quantity, cardNo, user);
        }
        
        public System.Threading.Tasks.Task<int> purchaseStockAsync(string stockSymbol, string quantity, string cardNo, string user) {
            return base.Channel.purchaseStockAsync(stockSymbol, quantity, cardNo, user);
        }
    }
}