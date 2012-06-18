﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstSOAPservice.HolidayService2Reference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/", ConfigurationName="HolidayService2Reference.HolidayService2Soap")]
    public interface HolidayService2Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.holidaywebservice.com/HolidayService_v2/GetCountriesAvailable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CodeDescriptionBase))]
        CountryCode[] GetCountriesAvailable();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.holidaywebservice.com/HolidayService_v2/GetHolidaysAvailable", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CodeDescriptionBase))]
        HolidayCode[] GetHolidaysAvailable(FirstSOAPservice.HolidayService2Reference.Country countryCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.holidaywebservice.com/HolidayService_v2/GetHolidayDate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CodeDescriptionBase))]
        System.DateTime GetHolidayDate(FirstSOAPservice.HolidayService2Reference.Country countryCode, string holidayCode, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.holidaywebservice.com/HolidayService_v2/GetHolidaysForDateRange", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CodeDescriptionBase))]
        Holiday[] GetHolidaysForDateRange(FirstSOAPservice.HolidayService2Reference.Country countryCode, System.DateTime startDate, System.DateTime endDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.holidaywebservice.com/HolidayService_v2/GetHolidaysForYear", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CodeDescriptionBase))]
        Holiday[] GetHolidaysForYear(FirstSOAPservice.HolidayService2Reference.Country countryCode, int year);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.holidaywebservice.com/HolidayService_v2/GetHolidaysForMonth", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CodeDescriptionBase))]
        Holiday[] GetHolidaysForMonth(FirstSOAPservice.HolidayService2Reference.Country countryCode, int year, int month);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public partial class CountryCode : CodeDescriptionBase {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RegionCode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HolidayCode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CountryCode))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public abstract partial class CodeDescriptionBase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string codeField;
        
        private string descriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
                this.RaisePropertyChanged("Code");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("Description");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public partial class Holiday : object, System.ComponentModel.INotifyPropertyChanged {
        
        private Country countryField;
        
        private string holidayCodeField;
        
        private string descriptorField;
        
        private HolidayType holidayTypeField;
        
        private HolidayDateType dateTypeField;
        
        private BankHoliday bankHolidayField;
        
        private System.DateTime dateField;
        
        private string relatedHolidayCodeField;
        
        private RegionCode[] applicableRegionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Country Country {
            get {
                return this.countryField;
            }
            set {
                this.countryField = value;
                this.RaisePropertyChanged("Country");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string HolidayCode {
            get {
                return this.holidayCodeField;
            }
            set {
                this.holidayCodeField = value;
                this.RaisePropertyChanged("HolidayCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Descriptor {
            get {
                return this.descriptorField;
            }
            set {
                this.descriptorField = value;
                this.RaisePropertyChanged("Descriptor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public HolidayType HolidayType {
            get {
                return this.holidayTypeField;
            }
            set {
                this.holidayTypeField = value;
                this.RaisePropertyChanged("HolidayType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public HolidayDateType DateType {
            get {
                return this.dateTypeField;
            }
            set {
                this.dateTypeField = value;
                this.RaisePropertyChanged("DateType");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public BankHoliday BankHoliday {
            get {
                return this.bankHolidayField;
            }
            set {
                this.bankHolidayField = value;
                this.RaisePropertyChanged("BankHoliday");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime Date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
                this.RaisePropertyChanged("Date");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string RelatedHolidayCode {
            get {
                return this.relatedHolidayCodeField;
            }
            set {
                this.relatedHolidayCodeField = value;
                this.RaisePropertyChanged("RelatedHolidayCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=8)]
        public RegionCode[] ApplicableRegions {
            get {
                return this.applicableRegionsField;
            }
            set {
                this.applicableRegionsField = value;
                this.RaisePropertyChanged("ApplicableRegions");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public enum Country {
        
        /// <remarks/>
        Canada,
        
        /// <remarks/>
        GreatBritain,
        
        /// <remarks/>
        IrelandNorthern,
        
        /// <remarks/>
        IrelandRepublicOf,
        
        /// <remarks/>
        Scotland,
        
        /// <remarks/>
        UnitedStates,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public enum HolidayType {
        
        /// <remarks/>
        Notable,
        
        /// <remarks/>
        Religious,
        
        /// <remarks/>
        NotableReligious,
        
        /// <remarks/>
        Other,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public enum HolidayDateType {
        
        /// <remarks/>
        Observed,
        
        /// <remarks/>
        Actual,
        
        /// <remarks/>
        ObservedActual,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public enum BankHoliday {
        
        /// <remarks/>
        Recognized,
        
        /// <remarks/>
        NotRecognized,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public partial class RegionCode : CodeDescriptionBase {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.holidaywebservice.com/HolidayService_v2/")]
    public partial class HolidayCode : CodeDescriptionBase {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HolidayService2SoapChannel : FirstSOAPservice.HolidayService2Reference.HolidayService2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HolidayService2SoapClient : System.ServiceModel.ClientBase<FirstSOAPservice.HolidayService2Reference.HolidayService2Soap>, FirstSOAPservice.HolidayService2Reference.HolidayService2Soap {
        
        public HolidayService2SoapClient() {
        }
        
        public HolidayService2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HolidayService2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HolidayService2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HolidayService2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CountryCode[] GetCountriesAvailable() {
            return base.Channel.GetCountriesAvailable();
        }
        
        public HolidayCode[] GetHolidaysAvailable(FirstSOAPservice.HolidayService2Reference.Country countryCode) {
            return base.Channel.GetHolidaysAvailable(countryCode);
        }
        
        public System.DateTime GetHolidayDate(FirstSOAPservice.HolidayService2Reference.Country countryCode, string holidayCode, int year) {
            return base.Channel.GetHolidayDate(countryCode, holidayCode, year);
        }
        
        public Holiday[] GetHolidaysForDateRange(FirstSOAPservice.HolidayService2Reference.Country countryCode, System.DateTime startDate, System.DateTime endDate) {
            return base.Channel.GetHolidaysForDateRange(countryCode, startDate, endDate);
        }
        
        public Holiday[] GetHolidaysForYear(FirstSOAPservice.HolidayService2Reference.Country countryCode, int year) {
            return base.Channel.GetHolidaysForYear(countryCode, year);
        }
        
        public Holiday[] GetHolidaysForMonth(FirstSOAPservice.HolidayService2Reference.Country countryCode, int year, int month) {
            return base.Channel.GetHolidaysForMonth(countryCode, year, month);
        }
    }
}