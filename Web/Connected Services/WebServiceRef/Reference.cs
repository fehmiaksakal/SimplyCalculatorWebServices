﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.WebServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://calculatorproject.org/", ConfigurationName="WebServiceRef.CalculatorBaseSoap")]
    public interface CalculatorBaseSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculatorproject.org/Plus", ReplyAction="*")]
        decimal Plus(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculatorproject.org/Plus", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> PlusAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculatorproject.org/Subtraction", ReplyAction="*")]
        decimal Subtraction(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculatorproject.org/Subtraction", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> SubtractionAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculatorproject.org/Multiply", ReplyAction="*")]
        decimal Multiply(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculatorproject.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> MultiplyAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculatorproject.org/Divide", ReplyAction="*")]
        decimal Divide(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://calculatorproject.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> DivideAsync(decimal a, decimal b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorBaseSoapChannel : Web.WebServiceRef.CalculatorBaseSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorBaseSoapClient : System.ServiceModel.ClientBase<Web.WebServiceRef.CalculatorBaseSoap>, Web.WebServiceRef.CalculatorBaseSoap {
        
        public CalculatorBaseSoapClient() {
        }
        
        public CalculatorBaseSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorBaseSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorBaseSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorBaseSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal Plus(decimal a, decimal b) {
            return base.Channel.Plus(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> PlusAsync(decimal a, decimal b) {
            return base.Channel.PlusAsync(a, b);
        }
        
        public decimal Subtraction(decimal a, decimal b) {
            return base.Channel.Subtraction(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> SubtractionAsync(decimal a, decimal b) {
            return base.Channel.SubtractionAsync(a, b);
        }
        
        public decimal Multiply(decimal a, decimal b) {
            return base.Channel.Multiply(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> MultiplyAsync(decimal a, decimal b) {
            return base.Channel.MultiplyAsync(a, b);
        }
        
        public decimal Divide(decimal a, decimal b) {
            return base.Channel.Divide(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> DivideAsync(decimal a, decimal b) {
            return base.Channel.DivideAsync(a, b);
        }
    }
}