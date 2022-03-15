using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    
    public class GetCardtoCardBalanceTransferModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [JsonPropertyName("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

        [JsonPropertyName("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }


    }

    public class GetCardtoCardBalanceTransferModelOutput
    {
        [JsonProperty("SrNumber")]
        [DataMember]
        public int SrNumber { get; set; }

        [JsonProperty("CardNumber")]
        [DataMember]
        public string CardNumber { get; set; }


        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [JsonProperty("VechileNo")]
        [DataMember]
        public string VechileNo { get; set; }

        [JsonProperty("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }


        [JsonProperty("IssueDate")]
        [DataMember]
        public string IssueDate { get; set; }



        [JsonProperty("ExpiryDate")]
        [DataMember]
        public string ExpiryDate { get; set; }


        [JsonProperty("Status")]
        [DataMember]
        public string Status { get; set; }


        [JsonProperty("CardBalance")]
        [DataMember]
        public float CardBalance { get; set; }


    }
}
