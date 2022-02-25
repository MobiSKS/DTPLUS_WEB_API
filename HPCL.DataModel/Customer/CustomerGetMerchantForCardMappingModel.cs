using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{


    public class CustomerGetMerchantForCardMappingModelInput : BaseClass
    {

        [JsonPropertyName("MerchantID")]
        [DataMember]
        public string MerchantID { get; set; }

        [Required]
        [JsonPropertyName("StateID")]
        [DataMember]
        public string StateID { get; set; }


        [JsonPropertyName("DistrictID")]
        [DataMember]
        public string DistrictID { get; set; }

        [JsonPropertyName("City")]
        [DataMember]
        public string City { get; set; }


        [JsonPropertyName("HighwayName")]
        [DataMember]
        public string HighwayName { get; set; }

        [JsonPropertyName("HighwayNo1")]
        [DataMember]
        public string HighwayNo1 { get; set; }

        [JsonPropertyName("HighwayNo2")]
        [DataMember]
        public string HighwayNo2 { get; set; }


    }

    public class CustomerGetMerchantForCardMappingModelOutput
    {


        [JsonProperty("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }


        [JsonProperty("MerchantName")]
        [DataMember]
        public string MerchantName { get; set; }


        [JsonProperty("RetailOutletName")]
        [DataMember]
        public string RetailOutletName { get; set; }


        [JsonProperty("Address")]
        [DataMember]
        public string Address { get; set; }


         

    }
}
