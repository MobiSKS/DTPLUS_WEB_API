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

        [Required]
        [JsonProperty("Mobileno")]
        [DataMember]
        public Int64 Mobileno { get; set; }

        
    }

    public class SMSSendOutputModel : BaseClassOutput
    {

    }
}
