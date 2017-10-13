﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppraisalSystem.Web.QuestionService {
    using System.Runtime.Serialization;
    using System;
    
    
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuestionService.IQuestionWcfService")]
    public interface IQuestionWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/GetQuestionsByCompetence", ReplyAction="http://tempuri.org/IQuestionWcfService/GetQuestionsByCompetenceResponse")]
        AppraisalSystem.Web.QuestionService.Question[] GetQuestionsByCompetence(string competence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/GetQuestionsByCompetence", ReplyAction="http://tempuri.org/IQuestionWcfService/GetQuestionsByCompetenceResponse")]
        System.Threading.Tasks.Task<AppraisalSystem.Web.QuestionService.Question[]> GetQuestionsByCompetenceAsync(string competence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/UpdateQuestion", ReplyAction="http://tempuri.org/IQuestionWcfService/UpdateQuestionResponse")]
        void UpdateQuestion(int questionId, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/UpdateQuestion", ReplyAction="http://tempuri.org/IQuestionWcfService/UpdateQuestionResponse")]
        System.Threading.Tasks.Task UpdateQuestionAsync(int questionId, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/GetAll", ReplyAction="http://tempuri.org/IQuestionWcfService/GetAllResponse")]
        AppraisalSystem.Web.QuestionService.Question[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/GetAll", ReplyAction="http://tempuri.org/IQuestionWcfService/GetAllResponse")]
        System.Threading.Tasks.Task<AppraisalSystem.Web.QuestionService.Question[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/AddQuestion", ReplyAction="http://tempuri.org/IQuestionWcfService/AddQuestionResponse")]
        void AddQuestion(string questionContent, string competence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/AddQuestion", ReplyAction="http://tempuri.org/IQuestionWcfService/AddQuestionResponse")]
        System.Threading.Tasks.Task AddQuestionAsync(string questionContent, string competence);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/Delete", ReplyAction="http://tempuri.org/IQuestionWcfService/DeleteResponse")]
        void Delete(int questionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IQuestionWcfService/Delete", ReplyAction="http://tempuri.org/IQuestionWcfService/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(int questionId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IQuestionWcfServiceChannel : AppraisalSystem.Web.QuestionService.IQuestionWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class QuestionWcfServiceClient : System.ServiceModel.ClientBase<AppraisalSystem.Web.QuestionService.IQuestionWcfService>, AppraisalSystem.Web.QuestionService.IQuestionWcfService {
        
        public QuestionWcfServiceClient() {
        }
        
        public QuestionWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public QuestionWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuestionWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public QuestionWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AppraisalSystem.Web.QuestionService.Question[] GetQuestionsByCompetence(string competence) {
            return base.Channel.GetQuestionsByCompetence(competence);
        }
        
        public System.Threading.Tasks.Task<AppraisalSystem.Web.QuestionService.Question[]> GetQuestionsByCompetenceAsync(string competence) {
            return base.Channel.GetQuestionsByCompetenceAsync(competence);
        }
        
        public void UpdateQuestion(int questionId, string content) {
            base.Channel.UpdateQuestion(questionId, content);
        }
        
        public System.Threading.Tasks.Task UpdateQuestionAsync(int questionId, string content) {
            return base.Channel.UpdateQuestionAsync(questionId, content);
        }
        
        public AppraisalSystem.Web.QuestionService.Question[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<AppraisalSystem.Web.QuestionService.Question[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public void AddQuestion(string questionContent, string competence) {
            base.Channel.AddQuestion(questionContent, competence);
        }
        
        public System.Threading.Tasks.Task AddQuestionAsync(string questionContent, string competence) {
            return base.Channel.AddQuestionAsync(questionContent, competence);
        }
        
        public void Delete(int questionId) {
            base.Channel.Delete(questionId);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(int questionId) {
            return base.Channel.DeleteAsync(questionId);
        }
    }
}
