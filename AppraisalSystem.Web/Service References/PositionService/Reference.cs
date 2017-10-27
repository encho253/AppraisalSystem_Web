﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppraisalSystem.Web.PositionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Position", Namespace="http://schemas.datacontract.org/2004/07/DB")]
    [System.SerializableAttribute()]
    public partial class Position : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Id {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PositionService.IPositionWcfService")]
    public interface IPositionWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPositionWcfService/GetAllPositionsByName", ReplyAction="http://tempuri.org/IPositionWcfService/GetAllPositionsByNameResponse")]
        string[] GetAllPositionsByName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPositionWcfService/GetAllPositionsByName", ReplyAction="http://tempuri.org/IPositionWcfService/GetAllPositionsByNameResponse")]
        System.Threading.Tasks.Task<string[]> GetAllPositionsByNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPositionWcfService/GetAllPositions", ReplyAction="http://tempuri.org/IPositionWcfService/GetAllPositionsResponse")]
        AppraisalSystem.Web.PositionService.Position[] GetAllPositions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPositionWcfService/GetAllPositions", ReplyAction="http://tempuri.org/IPositionWcfService/GetAllPositionsResponse")]
        System.Threading.Tasks.Task<AppraisalSystem.Web.PositionService.Position[]> GetAllPositionsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPositionWcfService/UpdatePosition", ReplyAction="http://tempuri.org/IPositionWcfService/UpdatePositionResponse")]
        void UpdatePosition(int id, string positionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPositionWcfService/UpdatePosition", ReplyAction="http://tempuri.org/IPositionWcfService/UpdatePositionResponse")]
        System.Threading.Tasks.Task UpdatePositionAsync(int id, string positionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPositionWcfService/AddPosition", ReplyAction="http://tempuri.org/IPositionWcfService/AddPositionResponse")]
        void AddPosition(string positionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPositionWcfService/AddPosition", ReplyAction="http://tempuri.org/IPositionWcfService/AddPositionResponse")]
        System.Threading.Tasks.Task AddPositionAsync(string positionName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPositionWcfServiceChannel : AppraisalSystem.Web.PositionService.IPositionWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PositionWcfServiceClient : System.ServiceModel.ClientBase<AppraisalSystem.Web.PositionService.IPositionWcfService>, AppraisalSystem.Web.PositionService.IPositionWcfService {
        
        public PositionWcfServiceClient() {
        }
        
        public PositionWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PositionWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PositionWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PositionWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetAllPositionsByName() {
            return base.Channel.GetAllPositionsByName();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllPositionsByNameAsync() {
            return base.Channel.GetAllPositionsByNameAsync();
        }
        
        public AppraisalSystem.Web.PositionService.Position[] GetAllPositions() {
            return base.Channel.GetAllPositions();
        }
        
        public System.Threading.Tasks.Task<AppraisalSystem.Web.PositionService.Position[]> GetAllPositionsAsync() {
            return base.Channel.GetAllPositionsAsync();
        }
        
        public void UpdatePosition(int id, string positionName) {
            base.Channel.UpdatePosition(id, positionName);
        }
        
        public System.Threading.Tasks.Task UpdatePositionAsync(int id, string positionName) {
            return base.Channel.UpdatePositionAsync(id, positionName);
        }
        
        public void AddPosition(string positionName) {
            base.Channel.AddPosition(positionName);
        }
        
        public System.Threading.Tasks.Task AddPositionAsync(string positionName) {
            return base.Channel.AddPositionAsync(positionName);
        }
    }
}
