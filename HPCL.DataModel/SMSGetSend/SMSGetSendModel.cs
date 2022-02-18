using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.SMSGetSend
{
    
    public class SMSGetInputModel : BaseClass
    {
         
    }

    public class SMSGetOutputModel
    {
        [JsonPropertyName("TemplateName")]
        [DataMember]
        public string TemplateName { get; set; }

        [JsonPropertyName("TemplateType")]
        [DataMember]
        public string TemplateType { get; set; }

        [JsonPropertyName("TemplateMessage")]
        [DataMember]
        public string TemplateMessage { get; set; }

        [JsonPropertyName("CTID")]
        [DataMember]
        public string CTID { get; set; }
    }

    public class SMSSendInputModel : BaseClass
    {

        [JsonPropertyName("CTID")]
        [DataMember]
        public string CTID { get; set; }
        
    }

    public class SMSSendOutputModel 
    {
        [JsonProperty("SenderId")]
        [DataMember]
        public string SenderId { get; set; }

        [JsonProperty("SMSAPIURL")]
        [DataMember]
        public string SMSAPIURL { get; set; }

        [JsonProperty("SMSText")]
        [DataMember]
        public string SMSText { get; set; }

        [JsonProperty("HeaderTemplate")]
        [DataMember]
        public string HeaderTemplate { get; set; }
    }

    public class InsertSMSTextEntryInputModel : BaseClass
    {

        [JsonPropertyName("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }

        [JsonPropertyName("HeaderTemplate")]
        [DataMember]
        public string HeaderTemplate { get; set; }

        [JsonPropertyName("CTID")]
        [DataMember]
        public string CTID { get; set; }

        [JsonPropertyName("SMSText")]
        [DataMember]
        public string SMSText { get; set; }

        [JsonPropertyName("SMSStatus")]
        [DataMember]
        public string SMSStatus { get; set; }

        [JsonPropertyName("SMSStatusDesc")]
        [DataMember]
        public string SMSStatusDesc { get; set; }

        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }

    }

    public class InsertSMSTextEntryOutputModel :BaseClassOutput
    {
         
    }
}
