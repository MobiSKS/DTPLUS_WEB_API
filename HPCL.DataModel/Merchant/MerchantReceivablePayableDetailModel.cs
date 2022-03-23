using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
   
    public class MerchantReceivablePayableDetailModelInput : BaseClass
    {
        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }


        [JsonPropertyName("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }


        [JsonPropertyName("FromDate")]
        [DataMember]
        public string FromDate { get; set; }


        [JsonPropertyName("ToDate")]
        [DataMember]
        public string ToDate { get; set; }

    }

    public class MerchantReceivablePayableDetailModelOutput
    {
        [JsonProperty("SrNumber")]
        [DataMember]
        public int SrNumber { get; set; }

        [JsonProperty("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }

        [JsonProperty("BatchId")]
        [DataMember]
        public Int64 BatchId { get; set; }


        [JsonProperty("SettlementDate")]
        [DataMember]
        public string SettlementDate { get; set; }


        [JsonProperty("Receivable")]
        [DataMember]
        public float Receivable { get; set; }


        [JsonProperty("Payable")]
        [DataMember]
        public float Payable { get; set; }

         

    }


}
