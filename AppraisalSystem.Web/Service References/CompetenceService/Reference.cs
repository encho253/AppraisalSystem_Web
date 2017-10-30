﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppraisalSystem.Web.CompetenceService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Competence", Namespace="http://schemas.datacontract.org/2004/07/DB")]
    [System.SerializableAttribute()]
    public partial class Competence : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AppraisalSystem.Web.CompetenceService.Question[] QuestionsField;
        
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
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AppraisalSystem.Web.CompetenceService.Question[] Questions {
            get {
                return this.QuestionsField;
            }
            set {
                if ((object.ReferenceEquals(this.QuestionsField, value) != true)) {
                    this.QuestionsField = value;
                    this.RaisePropertyChanged("Questions");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/DB")]
    [System.SerializableAttribute()]
    public partial class Question : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CompetenceIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> PositionIdField;
        
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
        public int CompetenceId {
            get {
                return this.CompetenceIdField;
            }
            set {
                if ((this.CompetenceIdField.Equals(value) != true)) {
                    this.CompetenceIdField = value;
                    this.RaisePropertyChanged("CompetenceId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Content {
            get {
                return this.ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.ContentField, value) != true)) {
                    this.ContentField = value;
                    this.RaisePropertyChanged("Content");
                }
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
        public System.Nullable<int> PositionId {
            get {
                return this.PositionIdField;
            }
            set {
                if ((this.PositionIdField.Equals(value) != true)) {
                    this.PositionIdField = value;
                    this.RaisePropertyChanged("PositionId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompetenceService.ICompetenceWcfService")]
    public interface ICompetenceWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesByName", ReplyAction="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesByNameResponse")]
        string[] GetAllCompetencesByName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesByName", ReplyAction="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesByNameResponse")]
        System.Threading.Tasks.Task<string[]> GetAllCompetencesByNameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/GetAllCompetences", ReplyAction="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesResponse")]
        AppraisalSystem.Web.CompetenceService.Competence[] GetAllCompetences();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/GetAllCompetences", ReplyAction="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesResponse")]
        System.Threading.Tasks.Task<AppraisalSystem.Web.CompetenceService.Competence[]> GetAllCompetencesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/GetAllCompetenceByPosition", ReplyAction="http://tempuri.org/ICompetenceWcfService/GetAllCompetenceByPositionResponse")]
        AppraisalSystem.Web.CompetenceService.Competence[] GetAllCompetenceByPosition(string positionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/GetAllCompetenceByPosition", ReplyAction="http://tempuri.org/ICompetenceWcfService/GetAllCompetenceByPositionResponse")]
        System.Threading.Tasks.Task<AppraisalSystem.Web.CompetenceService.Competence[]> GetAllCompetenceByPositionAsync(string positionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/AddCompetence", ReplyAction="http://tempuri.org/ICompetenceWcfService/AddCompetenceResponse")]
        void AddCompetence(string competenceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/AddCompetence", ReplyAction="http://tempuri.org/ICompetenceWcfService/AddCompetenceResponse")]
        System.Threading.Tasks.Task AddCompetenceAsync(string competenceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/UpdateCompetence", ReplyAction="http://tempuri.org/ICompetenceWcfService/UpdateCompetenceResponse")]
        void UpdateCompetence(int id, string competenceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/UpdateCompetence", ReplyAction="http://tempuri.org/ICompetenceWcfService/UpdateCompetenceResponse")]
        System.Threading.Tasks.Task UpdateCompetenceAsync(int id, string competenceName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesNameByPosition", ReplyAction="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesNameByPositionResponse")]
        string[] GetAllCompetencesNameByPosition(string positionName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesNameByPosition", ReplyAction="http://tempuri.org/ICompetenceWcfService/GetAllCompetencesNameByPositionResponse")]
        System.Threading.Tasks.Task<string[]> GetAllCompetencesNameByPositionAsync(string positionName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICompetenceWcfServiceChannel : AppraisalSystem.Web.CompetenceService.ICompetenceWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CompetenceWcfServiceClient : System.ServiceModel.ClientBase<AppraisalSystem.Web.CompetenceService.ICompetenceWcfService>, AppraisalSystem.Web.CompetenceService.ICompetenceWcfService {
        
        public CompetenceWcfServiceClient() {
        }
        
        public CompetenceWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CompetenceWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompetenceWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CompetenceWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetAllCompetencesByName() {
            return base.Channel.GetAllCompetencesByName();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllCompetencesByNameAsync() {
            return base.Channel.GetAllCompetencesByNameAsync();
        }
        
        public AppraisalSystem.Web.CompetenceService.Competence[] GetAllCompetences() {
            return base.Channel.GetAllCompetences();
        }
        
        public System.Threading.Tasks.Task<AppraisalSystem.Web.CompetenceService.Competence[]> GetAllCompetencesAsync() {
            return base.Channel.GetAllCompetencesAsync();
        }
        
        public AppraisalSystem.Web.CompetenceService.Competence[] GetAllCompetenceByPosition(string positionName) {
            return base.Channel.GetAllCompetenceByPosition(positionName);
        }
        
        public System.Threading.Tasks.Task<AppraisalSystem.Web.CompetenceService.Competence[]> GetAllCompetenceByPositionAsync(string positionName) {
            return base.Channel.GetAllCompetenceByPositionAsync(positionName);
        }
        
        public void AddCompetence(string competenceName) {
            base.Channel.AddCompetence(competenceName);
        }
        
        public System.Threading.Tasks.Task AddCompetenceAsync(string competenceName) {
            return base.Channel.AddCompetenceAsync(competenceName);
        }
        
        public void UpdateCompetence(int id, string competenceName) {
            base.Channel.UpdateCompetence(id, competenceName);
        }
        
        public System.Threading.Tasks.Task UpdateCompetenceAsync(int id, string competenceName) {
            return base.Channel.UpdateCompetenceAsync(id, competenceName);
        }
        
        public string[] GetAllCompetencesNameByPosition(string positionName) {
            return base.Channel.GetAllCompetencesNameByPosition(positionName);
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllCompetencesNameByPositionAsync(string positionName) {
            return base.Channel.GetAllCompetencesNameByPositionAsync(positionName);
        }
    }
}
