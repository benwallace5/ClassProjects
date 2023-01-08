﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginTryIt.LoginService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/signIn", ReplyAction="http://tempuri.org/IService1/signInResponse")]
        int signIn(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/signIn", ReplyAction="http://tempuri.org/IService1/signInResponse")]
        System.Threading.Tasks.Task<int> signInAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/signUp", ReplyAction="http://tempuri.org/IService1/signUpResponse")]
        int signUp(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/signUp", ReplyAction="http://tempuri.org/IService1/signUpResponse")]
        System.Threading.Tasks.Task<int> signUpAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : LoginTryIt.LoginService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<LoginTryIt.LoginService.IService1>, LoginTryIt.LoginService.IService1 {
        
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
        
        public int signIn(string username, string password) {
            return base.Channel.signIn(username, password);
        }
        
        public System.Threading.Tasks.Task<int> signInAsync(string username, string password) {
            return base.Channel.signInAsync(username, password);
        }
        
        public int signUp(string username, string password) {
            return base.Channel.signUp(username, password);
        }
        
        public System.Threading.Tasks.Task<int> signUpAsync(string username, string password) {
            return base.Channel.signUpAsync(username, password);
        }
    }
}