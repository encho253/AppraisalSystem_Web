﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppraisalSystem.Web.EvaluationTemplateService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EvaluationTemplate", Namespace="http://schemas.datacontract.org/2004/07/DB")]
    [System.SerializableAttribute()]
    public partial class EvaluationTemplate : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ExcelDataMappingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ExcelTemplateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QualificationIdField;
        
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
        public byte[] ExcelDataMapping {
            get {
                return this.ExcelDataMappingField;
            }
            set {
                if ((object.ReferenceEquals(this.ExcelDataMappingField, value) != true)) {
                    this.ExcelDataMappingField = value;
                    this.RaisePropertyChanged("ExcelDataMapping");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ExcelTemplate {
            get {
                return this.ExcelTemplateField;
            }
            set {
                if ((object.ReferenceEquals(this.ExcelTemplateField, value) != true)) {
                    this.ExcelTemplateField = value;
                    this.RaisePropertyChanged("ExcelTemplate");
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
        public int QualificationId {
            get {
                return this.QualificationIdField;
            }
            set {
                if ((this.QualificationIdField.Equals(value) != true)) {
                    this.QualificationIdField = value;
                    this.RaisePropertyChanged("QualificationId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EvaluationTemplateService.IEvaluationTemplateWcfService")]
    public interface IEvaluationTemplateWcfService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationTemplateWcfService/GetAllTemplates", ReplyAction="http://tempuri.org/IEvaluationTemplateWcfService/GetAllTemplatesResponse")]
        AppraisalSystem.Web.EvaluationTemplateService.EvaluationTemplate[] GetAllTemplates();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationTemplateWcfService/GetAllTemplates", ReplyAction="http://tempuri.org/IEvaluationTemplateWcfService/GetAllTemplatesResponse")]
        System.Threading.Tasks.Task<AppraisalSystem.Web.EvaluationTemplateService.EvaluationTemplate[]> GetAllTemplatesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationTemplateWcfService/CreateEvaluationTemplate", ReplyAction="http://tempuri.org/IEvaluationTemplateWcfService/CreateEvaluationTemplateResponse" +
            "")]
        void CreateEvaluationTemplate(int positionId, string templateName, int[] questionsId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvaluationTemplateWcfService/CreateEvaluationTemplate", ReplyAction="http://tempuri.org/IEvaluationTemplateWcfService/CreateEvaluationTemplateResponse" +
            "")]
        System.Threading.Tasks.Task CreateEvaluationTemplateAsync(int positionId, string templateName, int[] questionsId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEvaluationTemplateWcfServiceChannel : AppraisalSystem.Web.EvaluationTemplateService.IEvaluationTemplateWcfService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EvaluationTemplateWcfServiceClient : System.ServiceModel.ClientBase<AppraisalSystem.Web.EvaluationTemplateService.IEvaluationTemplateWcfService>, AppraisalSystem.Web.EvaluationTemplateService.IEvaluationTemplateWcfService {
        
        public EvaluationTemplateWcfServiceClient() {
        }
        
        public EvaluationTemplateWcfServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EvaluationTemplateWcfServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvaluationTemplateWcfServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvaluationTemplateWcfServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AppraisalSystem.Web.EvaluationTemplateService.EvaluationTemplate[] GetAllTemplates() {
            return base.Channel.GetAllTemplates();
        }
        
        public System.Threading.Tasks.Task<AppraisalSystem.Web.EvaluationTemplateService.EvaluationTemplate[]> GetAllTemplatesAsync() {
            return base.Channel.GetAllTemplatesAsync();
        }
        
        public void CreateEvaluationTemplate(int positionId, string templateName, int[] questionsId) {
            base.Channel.CreateEvaluationTemplate(positionId, templateName, questionsId);
        }
        
        public System.Threading.Tasks.Task CreateEvaluationTemplateAsync(int positionId, string templateName, int[] questionsId) {
            return base.Channel.CreateEvaluationTemplateAsync(positionId, templateName, questionsId);
        }
    }
}
