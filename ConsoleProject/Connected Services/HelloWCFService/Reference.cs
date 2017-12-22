﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloLucian.HelloWCFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloWCFService.IHelloWCF")]
    public interface IHelloWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWCF/GetProductName", ReplyAction="http://tempuri.org/IHelloWCF/GetProductNameResponse")]
        string GetProductName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWCF/GetProductName", ReplyAction="http://tempuri.org/IHelloWCF/GetProductNameResponse")]
        System.Threading.Tasks.Task<string> GetProductNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWCF/GetProductNameByID", ReplyAction="http://tempuri.org/IHelloWCF/GetProductNameByIDResponse")]
        string GetProductNameByID(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWCF/GetProductNameByID", ReplyAction="http://tempuri.org/IHelloWCF/GetProductNameByIDResponse")]
        System.Threading.Tasks.Task<string> GetProductNameByIDAsync(int ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWCFChannel : HelloLucian.HelloWCFService.IHelloWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWCFClient : System.ServiceModel.ClientBase<HelloLucian.HelloWCFService.IHelloWCF>, HelloLucian.HelloWCFService.IHelloWCF {
        
        public HelloWCFClient() {
        }
        
        public HelloWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetProductName() {
            return base.Channel.GetProductName();
        }
        
        public System.Threading.Tasks.Task<string> GetProductNameAsync() {
            return base.Channel.GetProductNameAsync();
        }
        
        public string GetProductNameByID(int ID) {
            return base.Channel.GetProductNameByID(ID);
        }
        
        public System.Threading.Tasks.Task<string> GetProductNameByIDAsync(int ID) {
            return base.Channel.GetProductNameByIDAsync(ID);
        }
    }
}
