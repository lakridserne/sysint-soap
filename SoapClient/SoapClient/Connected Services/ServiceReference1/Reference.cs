﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Order", Namespace="http://schemas.datacontract.org/2004/07/SoapServer")]
    [System.SerializableAttribute()]
    public partial class Order : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
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
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Product {
            get {
                return this.ProductField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductField, value) != true)) {
                    this.ProductField = value;
                    this.RaisePropertyChanged("Product");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetallOrders", ReplyAction="http://tempuri.org/IService1/GetallOrdersResponse")]
        SoapClient.ServiceReference1.Order[] GetallOrders();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetallOrders", ReplyAction="http://tempuri.org/IService1/GetallOrdersResponse")]
        System.Threading.Tasks.Task<SoapClient.ServiceReference1.Order[]> GetallOrdersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindOrder", ReplyAction="http://tempuri.org/IService1/FindOrderResponse")]
        SoapClient.ServiceReference1.Order FindOrder(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindOrder", ReplyAction="http://tempuri.org/IService1/FindOrderResponse")]
        System.Threading.Tasks.Task<SoapClient.ServiceReference1.Order> FindOrderAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrder", ReplyAction="http://tempuri.org/IService1/DeleteOrderResponse")]
        void DeleteOrder(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteOrder", ReplyAction="http://tempuri.org/IService1/DeleteOrderResponse")]
        System.Threading.Tasks.Task DeleteOrderAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddOrder", ReplyAction="http://tempuri.org/IService1/AddOrderResponse")]
        void AddOrder(int id, string name, string product, int price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddOrder", ReplyAction="http://tempuri.org/IService1/AddOrderResponse")]
        System.Threading.Tasks.Task AddOrderAsync(int id, string name, string product, int price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateOrder", ReplyAction="http://tempuri.org/IService1/UpdateOrderResponse")]
        void UpdateOrder(int id, string name, string product, int price);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateOrder", ReplyAction="http://tempuri.org/IService1/UpdateOrderResponse")]
        System.Threading.Tasks.Task UpdateOrderAsync(int id, string name, string product, int price);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SoapClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SoapClient.ServiceReference1.IService1>, SoapClient.ServiceReference1.IService1 {
        
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
        
        public SoapClient.ServiceReference1.Order[] GetallOrders() {
            return base.Channel.GetallOrders();
        }
        
        public System.Threading.Tasks.Task<SoapClient.ServiceReference1.Order[]> GetallOrdersAsync() {
            return base.Channel.GetallOrdersAsync();
        }
        
        public SoapClient.ServiceReference1.Order FindOrder(int id) {
            return base.Channel.FindOrder(id);
        }
        
        public System.Threading.Tasks.Task<SoapClient.ServiceReference1.Order> FindOrderAsync(int id) {
            return base.Channel.FindOrderAsync(id);
        }
        
        public void DeleteOrder(int id) {
            base.Channel.DeleteOrder(id);
        }
        
        public System.Threading.Tasks.Task DeleteOrderAsync(int id) {
            return base.Channel.DeleteOrderAsync(id);
        }
        
        public void AddOrder(int id, string name, string product, int price) {
            base.Channel.AddOrder(id, name, product, price);
        }
        
        public System.Threading.Tasks.Task AddOrderAsync(int id, string name, string product, int price) {
            return base.Channel.AddOrderAsync(id, name, product, price);
        }
        
        public void UpdateOrder(int id, string name, string product, int price) {
            base.Channel.UpdateOrder(id, name, product, price);
        }
        
        public System.Threading.Tasks.Task UpdateOrderAsync(int id, string name, string product, int price) {
            return base.Channel.UpdateOrderAsync(id, name, product, price);
        }
    }
}
