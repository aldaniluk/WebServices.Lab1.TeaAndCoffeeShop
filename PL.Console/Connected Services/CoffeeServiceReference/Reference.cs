﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PL.Console.CoffeeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CoffeeBll", Namespace="http://schemas.datacontract.org/2004/07/BLL.Models")]
    [System.SerializableAttribute()]
    public partial class CoffeeBll : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PL.Console.CoffeeServiceReference.CoffeeSortBll CoffeeSortField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PL.Console.CoffeeServiceReference.CountryBll MadeFromCountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceFor100GrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PL.Console.CoffeeServiceReference.QualityBll QualityIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PL.Console.CoffeeServiceReference.CoffeeSortBll CoffeeSort {
            get {
                return this.CoffeeSortField;
            }
            set {
                if ((this.CoffeeSortField.Equals(value) != true)) {
                    this.CoffeeSortField = value;
                    this.RaisePropertyChanged("CoffeeSort");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PL.Console.CoffeeServiceReference.CountryBll MadeFromCountry {
            get {
                return this.MadeFromCountryField;
            }
            set {
                if ((object.ReferenceEquals(this.MadeFromCountryField, value) != true)) {
                    this.MadeFromCountryField = value;
                    this.RaisePropertyChanged("MadeFromCountry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal PriceFor100Gr {
            get {
                return this.PriceFor100GrField;
            }
            set {
                if ((this.PriceFor100GrField.Equals(value) != true)) {
                    this.PriceFor100GrField = value;
                    this.RaisePropertyChanged("PriceFor100Gr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PL.Console.CoffeeServiceReference.QualityBll QualityId {
            get {
                return this.QualityIdField;
            }
            set {
                if ((this.QualityIdField.Equals(value) != true)) {
                    this.QualityIdField = value;
                    this.RaisePropertyChanged("QualityId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CountryBll", Namespace="http://schemas.datacontract.org/2004/07/BLL.Models")]
    [System.SerializableAttribute()]
    public partial class CountryBll : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CoffeeSortBll", Namespace="http://schemas.datacontract.org/2004/07/BLL.Models")]
    public enum CoffeeSortBll : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Arabica = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Robusta = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Liberica = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="QualityBll", Namespace="http://schemas.datacontract.org/2004/07/BLL.Models")]
    public enum QualityBll : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        High = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Medium = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Low = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CoffeeServiceReference.ICoffeeService")]
    public interface ICoffeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICoffeeService/GetAll", ReplyAction="http://tempuri.org/ICoffeeService/GetAllResponse")]
        PL.Console.CoffeeServiceReference.CoffeeBll[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICoffeeService/GetAll", ReplyAction="http://tempuri.org/ICoffeeService/GetAllResponse")]
        System.Threading.Tasks.Task<PL.Console.CoffeeServiceReference.CoffeeBll[]> GetAllAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICoffeeServiceChannel : PL.Console.CoffeeServiceReference.ICoffeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CoffeeServiceClient : System.ServiceModel.ClientBase<PL.Console.CoffeeServiceReference.ICoffeeService>, PL.Console.CoffeeServiceReference.ICoffeeService {
        
        public CoffeeServiceClient() {
        }
        
        public CoffeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CoffeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoffeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoffeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public PL.Console.CoffeeServiceReference.CoffeeBll[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<PL.Console.CoffeeServiceReference.CoffeeBll[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
    }
}