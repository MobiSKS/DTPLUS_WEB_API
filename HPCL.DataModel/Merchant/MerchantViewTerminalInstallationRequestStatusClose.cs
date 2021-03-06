using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{


    public class MerchantViewTerminalInstallationRequestStatusCloseInput : BaseClass
    {
        [Required]
        [JsonPropertyName("FromDate")]
        [DataMember]
        public string FromDate { get; set; }

        [Required]
        [JsonPropertyName("ToDate")]
        [DataMember]
        public string ToDate { get; set; }

        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }


        [JsonPropertyName("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }


        [JsonPropertyName("ZonalOfficeId")]
        [DataMember]
        public string ZonalOfficeId { get; set; }

        [JsonPropertyName("RegionalOfficeId")]
        [DataMember]
        public string RegionalOfficeId { get; set; }
    }

    public class MerchantViewTerminalInstallationRequestStatusCloseModelOutput
    {

        [JsonProperty("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }


        [JsonProperty("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }

        [JsonProperty("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }

        [JsonProperty("CreatedDate")]
        [DataMember]
        public string CreatedDate { get; set; }


        [JsonProperty("Remark")]
        [DataMember]
        public string Remark { get; set; }

        [JsonProperty("TerminalType")]
        [DataMember]
        public string TerminalType { get; set; }


        [JsonProperty("Status")]
        [DataMember]
        public string Status { get; set; }

        //[JsonProperty("DeploymentStatus")]
        //[DataMember]
        //public string DeploymentStatus { get; set; }

        //[JsonProperty("TerminalStatus")]
        //[DataMember]
        //public string TerminalStatus { get; set; }

    }
}
