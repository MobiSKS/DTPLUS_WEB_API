using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
    public class MerchantGetTerminalDeinstallationRequestModelInput : BaseClass
    {
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

    public class MerchantGetTerminalDeinstallationRequestModelOutput
    {
        [JsonProperty("ObjMerchantDeinstallationDetail")]
        public List<MerchantDeinstallationDetailOutput> ObjMerchantDeinstallationDetail { get; set; }

        [JsonProperty("ObjTerminalDeinstallationDetail")]
        public List<TerminalDeinstallationDetailOutput> ObjTerminalDeinstallationDetail { get; set; }
    }

    public class MerchantDeinstallationDetailOutput
    {
        [JsonProperty("MerchantName")]
        [DataMember]
        public string MerchantName { get; set; }


        [JsonProperty("RetailOutletName")]
        [DataMember]
        public string RetailOutletName { get; set; }

        [JsonProperty("Address")]
        [DataMember]
        public string Address { get; set; }


        [JsonProperty("City")]
        [DataMember]
        public string City { get; set; }


        [JsonProperty("State")]
        [DataMember]
        public string State { get; set; }


        [JsonProperty("District")]
        [DataMember]
        public string District { get; set; }
    }

    public class TerminalDeinstallationDetailOutput
    {
        [JsonProperty("ZonalOfficeName")]
        [DataMember]
        public string ZonalOfficeName { get; set; }


        [JsonProperty("RegionalOfficeName")]
        [DataMember]
        public string RegionalOfficeName { get; set; }


        [JsonProperty("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }


        [JsonProperty("CreatedTime")]
        [DataMember]
        public string CreatedTime { get; set; }
         
    }
}
