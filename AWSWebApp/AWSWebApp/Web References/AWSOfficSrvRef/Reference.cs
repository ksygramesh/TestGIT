﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36365
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.36365.
// 
#pragma warning disable 1591

namespace AWSWebApp.AWSOfficSrvRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="OfficeServicesSoap", Namespace="http://tempuri.org/")]
    public partial class OfficeServices : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllOfficesOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public OfficeServices() {
            this.Url = global::AWSWebApp.Properties.Settings.Default.AWSWebApp_AWSOfficSrvRef_OfficeServices;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetAllOfficesCompletedEventHandler GetAllOfficesCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllOffices", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public OfficeEntitity[] GetAllOffices() {
            object[] results = this.Invoke("GetAllOffices", new object[0]);
            return ((OfficeEntitity[])(results[0]));
        }
        
        /// <remarks/>
        public void GetAllOfficesAsync() {
            this.GetAllOfficesAsync(null);
        }
        
        /// <remarks/>
        public void GetAllOfficesAsync(object userState) {
            if ((this.GetAllOfficesOperationCompleted == null)) {
                this.GetAllOfficesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllOfficesOperationCompleted);
            }
            this.InvokeAsync("GetAllOffices", new object[0], this.GetAllOfficesOperationCompleted, userState);
        }
        
        private void OnGetAllOfficesOperationCompleted(object arg) {
            if ((this.GetAllOfficesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllOfficesCompleted(this, new GetAllOfficesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34283")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class OfficeEntitity {
        
        private string officeCodeField;
        
        private string cityField;
        
        private string phoneField;
        
        private string addressLine1Field;
        
        private string addressLine2Field;
        
        private string stateField;
        
        private string countryField;
        
        private string postalCodeField;
        
        private string territoryField;
        
        /// <remarks/>
        public string officeCode {
            get {
                return this.officeCodeField;
            }
            set {
                this.officeCodeField = value;
            }
        }
        
        /// <remarks/>
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public string addressLine1 {
            get {
                return this.addressLine1Field;
            }
            set {
                this.addressLine1Field = value;
            }
        }
        
        /// <remarks/>
        public string addressLine2 {
            get {
                return this.addressLine2Field;
            }
            set {
                this.addressLine2Field = value;
            }
        }
        
        /// <remarks/>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        public string postalCode {
            get {
                return this.postalCodeField;
            }
            set {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        public string territory {
            get {
                return this.territoryField;
            }
            set {
                this.territoryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetAllOfficesCompletedEventHandler(object sender, GetAllOfficesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllOfficesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllOfficesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public OfficeEntitity[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((OfficeEntitity[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591