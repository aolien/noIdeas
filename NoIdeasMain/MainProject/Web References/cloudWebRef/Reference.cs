﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.4927.
// 
namespace MainProject.cloudWebRef {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="NoIdeasWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class NoIdeasWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public NoIdeasWebService() {
            this.Url = "http://127.0.0.1:5100/NoIdeasWebService.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateProfile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool UpdateProfile(Profile profile) {
            object[] results = this.Invoke("UpdateProfile", new object[] {
                        profile});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateProfile(Profile profile, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateProfile", new object[] {
                        profile}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndUpdateProfile(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/LoadDatingProfile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool LoadDatingProfile(DatingProfile dprofile) {
            object[] results = this.Invoke("LoadDatingProfile", new object[] {
                        dprofile});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginLoadDatingProfile(DatingProfile dprofile, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("LoadDatingProfile", new object[] {
                        dprofile}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndLoadDatingProfile(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeletedatingProfile", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool DeletedatingProfile(DatingProfile dprofile) {
            object[] results = this.Invoke("DeletedatingProfile", new object[] {
                        dprofile});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDeletedatingProfile(DatingProfile dprofile, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeletedatingProfile", new object[] {
                        dprofile}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndDeletedatingProfile(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FindMatches", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataTable FindMatches(double longitude, double latitude) {
            object[] results = this.Invoke("FindMatches", new object[] {
                        longitude,
                        latitude});
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginFindMatches(double longitude, double latitude, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("FindMatches", new object[] {
                        longitude,
                        latitude}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataTable EndFindMatches(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataTable)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EndSession", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool EndSession(Profile profile) {
            object[] results = this.Invoke("EndSession", new object[] {
                        profile});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginEndSession(Profile profile, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("EndSession", new object[] {
                        profile}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndEndSession(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetNumberOfActiveUsers", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int GetNumberOfActiveUsers() {
            object[] results = this.Invoke("GetNumberOfActiveUsers", new object[0]);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetNumberOfActiveUsers(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetNumberOfActiveUsers", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public int EndGetNumberOfActiveUsers(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Profile {
        
        private string passwordField;
        
        private int phoneField;
        
        private double longitudeField;
        
        private double latitudeField;
        
        private double distanceField;
        
        private int interest3Field;
        
        private int interest2Field;
        
        private int interest1Field;
        
        private int hairField;
        
        private int weightField;
        
        private int height_inField;
        
        private int height_ftField;
        
        private int raceField;
        
        private int onlineField;
        
        private string nameField;
        
        private string lastNameField;
        
        private int ageField;
        
        private string nickNameField;
        
        private string sexField;
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public int Phone {
            get {
                return this.phoneField;
            }
            set {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        public double Longitude {
            get {
                return this.longitudeField;
            }
            set {
                this.longitudeField = value;
            }
        }
        
        /// <remarks/>
        public double Latitude {
            get {
                return this.latitudeField;
            }
            set {
                this.latitudeField = value;
            }
        }
        
        /// <remarks/>
        public double Distance {
            get {
                return this.distanceField;
            }
            set {
                this.distanceField = value;
            }
        }
        
        /// <remarks/>
        public int Interest3 {
            get {
                return this.interest3Field;
            }
            set {
                this.interest3Field = value;
            }
        }
        
        /// <remarks/>
        public int Interest2 {
            get {
                return this.interest2Field;
            }
            set {
                this.interest2Field = value;
            }
        }
        
        /// <remarks/>
        public int Interest1 {
            get {
                return this.interest1Field;
            }
            set {
                this.interest1Field = value;
            }
        }
        
        /// <remarks/>
        public int Hair {
            get {
                return this.hairField;
            }
            set {
                this.hairField = value;
            }
        }
        
        /// <remarks/>
        public int Weight {
            get {
                return this.weightField;
            }
            set {
                this.weightField = value;
            }
        }
        
        /// <remarks/>
        public int Height_in {
            get {
                return this.height_inField;
            }
            set {
                this.height_inField = value;
            }
        }
        
        /// <remarks/>
        public int Height_ft {
            get {
                return this.height_ftField;
            }
            set {
                this.height_ftField = value;
            }
        }
        
        /// <remarks/>
        public int Race {
            get {
                return this.raceField;
            }
            set {
                this.raceField = value;
            }
        }
        
        /// <remarks/>
        public int Online {
            get {
                return this.onlineField;
            }
            set {
                this.onlineField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string LastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public int Age {
            get {
                return this.ageField;
            }
            set {
                this.ageField = value;
            }
        }
        
        /// <remarks/>
        public string NickName {
            get {
                return this.nickNameField;
            }
            set {
                this.nickNameField = value;
            }
        }
        
        /// <remarks/>
        public string Sex {
            get {
                return this.sexField;
            }
            set {
                this.sexField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class DatingProfile {
        
        private int interest3Field;
        
        private int interest2Field;
        
        private int interest1Field;
        
        private int hairField;
        
        private int max_WeightField;
        
        private int min_WeightField;
        
        private int max_Height_inField;
        
        private int min_Height_inField;
        
        private int max_Height_ftField;
        
        private int min_Height_ftField;
        
        private int raceField;
        
        private int min_AgeField;
        
        private int max_AgeField;
        
        private string nickNameField;
        
        private string sexField;
        
        /// <remarks/>
        public int Interest3 {
            get {
                return this.interest3Field;
            }
            set {
                this.interest3Field = value;
            }
        }
        
        /// <remarks/>
        public int Interest2 {
            get {
                return this.interest2Field;
            }
            set {
                this.interest2Field = value;
            }
        }
        
        /// <remarks/>
        public int Interest1 {
            get {
                return this.interest1Field;
            }
            set {
                this.interest1Field = value;
            }
        }
        
        /// <remarks/>
        public int Hair {
            get {
                return this.hairField;
            }
            set {
                this.hairField = value;
            }
        }
        
        /// <remarks/>
        public int Max_Weight {
            get {
                return this.max_WeightField;
            }
            set {
                this.max_WeightField = value;
            }
        }
        
        /// <remarks/>
        public int Min_Weight {
            get {
                return this.min_WeightField;
            }
            set {
                this.min_WeightField = value;
            }
        }
        
        /// <remarks/>
        public int Max_Height_in {
            get {
                return this.max_Height_inField;
            }
            set {
                this.max_Height_inField = value;
            }
        }
        
        /// <remarks/>
        public int Min_Height_in {
            get {
                return this.min_Height_inField;
            }
            set {
                this.min_Height_inField = value;
            }
        }
        
        /// <remarks/>
        public int Max_Height_ft {
            get {
                return this.max_Height_ftField;
            }
            set {
                this.max_Height_ftField = value;
            }
        }
        
        /// <remarks/>
        public int Min_Height_ft {
            get {
                return this.min_Height_ftField;
            }
            set {
                this.min_Height_ftField = value;
            }
        }
        
        /// <remarks/>
        public int Race {
            get {
                return this.raceField;
            }
            set {
                this.raceField = value;
            }
        }
        
        /// <remarks/>
        public int Min_Age {
            get {
                return this.min_AgeField;
            }
            set {
                this.min_AgeField = value;
            }
        }
        
        /// <remarks/>
        public int Max_Age {
            get {
                return this.max_AgeField;
            }
            set {
                this.max_AgeField = value;
            }
        }
        
        /// <remarks/>
        public string NickName {
            get {
                return this.nickNameField;
            }
            set {
                this.nickNameField = value;
            }
        }
        
        /// <remarks/>
        public string Sex {
            get {
                return this.sexField;
            }
            set {
                this.sexField = value;
            }
        }
    }
}