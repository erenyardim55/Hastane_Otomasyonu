﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eczane.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ReceteItem", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ReceteItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ilackoduField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hastaadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string hastatcField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string recetekoduField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ilacadetField;
        
        private System.Nullable<System.DateTime> recetetarihField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string ilackodu {
            get {
                return this.ilackoduField;
            }
            set {
                if ((object.ReferenceEquals(this.ilackoduField, value) != true)) {
                    this.ilackoduField = value;
                    this.RaisePropertyChanged("ilackodu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string hastaad {
            get {
                return this.hastaadField;
            }
            set {
                if ((object.ReferenceEquals(this.hastaadField, value) != true)) {
                    this.hastaadField = value;
                    this.RaisePropertyChanged("hastaad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string hastatc {
            get {
                return this.hastatcField;
            }
            set {
                if ((object.ReferenceEquals(this.hastatcField, value) != true)) {
                    this.hastatcField = value;
                    this.RaisePropertyChanged("hastatc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string recetekodu {
            get {
                return this.recetekoduField;
            }
            set {
                if ((object.ReferenceEquals(this.recetekoduField, value) != true)) {
                    this.recetekoduField = value;
                    this.RaisePropertyChanged("recetekodu");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string ilacadet {
            get {
                return this.ilacadetField;
            }
            set {
                if ((object.ReferenceEquals(this.ilacadetField, value) != true)) {
                    this.ilacadetField = value;
                    this.RaisePropertyChanged("ilacadet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<System.DateTime> recetetarih {
            get {
                return this.recetetarihField;
            }
            set {
                if ((this.recetetarihField.Equals(value) != true)) {
                    this.recetetarihField = value;
                    this.RaisePropertyChanged("recetetarih");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name GetReceteResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRecete", ReplyAction="*")]
        Eczane.ServiceReference1.GetReceteResponse GetRecete(Eczane.ServiceReference1.GetReceteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetRecete", ReplyAction="*")]
        System.Threading.Tasks.Task<Eczane.ServiceReference1.GetReceteResponse> GetReceteAsync(Eczane.ServiceReference1.GetReceteRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetReceteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecete", Namespace="http://tempuri.org/", Order=0)]
        public Eczane.ServiceReference1.GetReceteRequestBody Body;
        
        public GetReceteRequest() {
        }
        
        public GetReceteRequest(Eczane.ServiceReference1.GetReceteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetReceteRequestBody {
        
        public GetReceteRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetReceteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetReceteResponse", Namespace="http://tempuri.org/", Order=0)]
        public Eczane.ServiceReference1.GetReceteResponseBody Body;
        
        public GetReceteResponse() {
        }
        
        public GetReceteResponse(Eczane.ServiceReference1.GetReceteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetReceteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Eczane.ServiceReference1.ReceteItem[] GetReceteResult;
        
        public GetReceteResponseBody() {
        }
        
        public GetReceteResponseBody(Eczane.ServiceReference1.ReceteItem[] GetReceteResult) {
            this.GetReceteResult = GetReceteResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Eczane.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Eczane.ServiceReference1.WebService1Soap>, Eczane.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Eczane.ServiceReference1.GetReceteResponse Eczane.ServiceReference1.WebService1Soap.GetRecete(Eczane.ServiceReference1.GetReceteRequest request) {
            return base.Channel.GetRecete(request);
        }
        
        public Eczane.ServiceReference1.ReceteItem[] GetRecete() {
            Eczane.ServiceReference1.GetReceteRequest inValue = new Eczane.ServiceReference1.GetReceteRequest();
            inValue.Body = new Eczane.ServiceReference1.GetReceteRequestBody();
            Eczane.ServiceReference1.GetReceteResponse retVal = ((Eczane.ServiceReference1.WebService1Soap)(this)).GetRecete(inValue);
            return retVal.Body.GetReceteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Eczane.ServiceReference1.GetReceteResponse> Eczane.ServiceReference1.WebService1Soap.GetReceteAsync(Eczane.ServiceReference1.GetReceteRequest request) {
            return base.Channel.GetReceteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Eczane.ServiceReference1.GetReceteResponse> GetReceteAsync() {
            Eczane.ServiceReference1.GetReceteRequest inValue = new Eczane.ServiceReference1.GetReceteRequest();
            inValue.Body = new Eczane.ServiceReference1.GetReceteRequestBody();
            return ((Eczane.ServiceReference1.WebService1Soap)(this)).GetReceteAsync(inValue);
        }
    }
}