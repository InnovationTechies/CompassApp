﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceCompassLibrary.CompassServiceApp {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PnpProducts", Namespace="http://schemas.datacontract.org/2004/07/WcfEcompassService")]
    [System.SerializableAttribute()]
    public partial class PnpProducts : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private WcfServiceCompassLibrary.CompassServiceApp.ProductCatagory CatagoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ProductDateEndPromoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductDescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProductDropPercentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProductIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float ProductPriceField;
        
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
        public WcfServiceCompassLibrary.CompassServiceApp.ProductCatagory Catagory {
            get {
                return this.CatagoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CatagoryField, value) != true)) {
                    this.CatagoryField = value;
                    this.RaisePropertyChanged("Catagory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ProductDateEndPromo {
            get {
                return this.ProductDateEndPromoField;
            }
            set {
                if ((this.ProductDateEndPromoField.Equals(value) != true)) {
                    this.ProductDateEndPromoField = value;
                    this.RaisePropertyChanged("ProductDateEndPromo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductDesc {
            get {
                return this.ProductDescField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductDescField, value) != true)) {
                    this.ProductDescField = value;
                    this.RaisePropertyChanged("ProductDesc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ProductDropPercent {
            get {
                return this.ProductDropPercentField;
            }
            set {
                if ((this.ProductDropPercentField.Equals(value) != true)) {
                    this.ProductDropPercentField = value;
                    this.RaisePropertyChanged("ProductDropPercent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProductID {
            get {
                return this.ProductIDField;
            }
            set {
                if ((this.ProductIDField.Equals(value) != true)) {
                    this.ProductIDField = value;
                    this.RaisePropertyChanged("ProductID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductImage {
            get {
                return this.ProductImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductImageField, value) != true)) {
                    this.ProductImageField = value;
                    this.RaisePropertyChanged("ProductImage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float ProductPrice {
            get {
                return this.ProductPriceField;
            }
            set {
                if ((this.ProductPriceField.Equals(value) != true)) {
                    this.ProductPriceField = value;
                    this.RaisePropertyChanged("ProductPrice");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductCatagory", Namespace="http://schemas.datacontract.org/2004/07/WcfEcompassService")]
    [System.SerializableAttribute()]
    public partial class ProductCatagory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CatagoryDescField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CatagoryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int catagoryIDField;
        
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
        public string CatagoryDesc {
            get {
                return this.CatagoryDescField;
            }
            set {
                if ((object.ReferenceEquals(this.CatagoryDescField, value) != true)) {
                    this.CatagoryDescField = value;
                    this.RaisePropertyChanged("CatagoryDesc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CatagoryName {
            get {
                return this.CatagoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CatagoryNameField, value) != true)) {
                    this.CatagoryNameField = value;
                    this.RaisePropertyChanged("CatagoryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int catagoryID {
            get {
                return this.catagoryIDField;
            }
            set {
                if ((this.catagoryIDField.Equals(value) != true)) {
                    this.catagoryIDField = value;
                    this.RaisePropertyChanged("catagoryID");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompassServiceApp.ICompassService")]
    public interface ICompassService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompassService/SayHelloTo", ReplyAction="http://tempuri.org/ICompassService/SayHelloToResponse")]
        string SayHelloTo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompassService/SayHelloTo", ReplyAction="http://tempuri.org/ICompassService/SayHelloToResponse")]
        System.Threading.Tasks.Task<string> SayHelloToAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompassService/GetProductsData", ReplyAction="http://tempuri.org/ICompassService/GetProductsDataResponse")]
        WcfServiceCompassLibrary.CompassServiceApp.PnpProducts[] GetProductsData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompassService/GetProductsData", ReplyAction="http://tempuri.org/ICompassService/GetProductsDataResponse")]
        System.Threading.Tasks.Task<WcfServiceCompassLibrary.CompassServiceApp.PnpProducts[]> GetProductsDataAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompassServiceChannel : WcfServiceCompassLibrary.CompassServiceApp.ICompassService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompassServiceClient : System.ServiceModel.ClientBase<WcfServiceCompassLibrary.CompassServiceApp.ICompassService>, WcfServiceCompassLibrary.CompassServiceApp.ICompassService {
        
        public CompassServiceClient() {
        }
        
        public CompassServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompassServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompassServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompassServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHelloTo() {
            return base.Channel.SayHelloTo();
        }
        
        public System.Threading.Tasks.Task<string> SayHelloToAsync() {
            return base.Channel.SayHelloToAsync();
        }
        
        public WcfServiceCompassLibrary.CompassServiceApp.PnpProducts[] GetProductsData() {
            return base.Channel.GetProductsData();
        }
        
        public System.Threading.Tasks.Task<WcfServiceCompassLibrary.CompassServiceApp.PnpProducts[]> GetProductsDataAsync() {
            return base.Channel.GetProductsDataAsync();
        }
    }
}
