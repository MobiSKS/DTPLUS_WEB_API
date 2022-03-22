using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace HPCL.DataModel.Merchant
{
    public class MerchantSaleReloadDeltaDetailModelInput : BaseClass
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

    public class MerchantSaleReloadDeltaDetailModelOutput
    {
        [JsonProperty("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }


        [JsonProperty("BatchId")]
        [DataMember]
        public Int64 BatchId { get; set; }


        [JsonProperty("SettlementDate")]
        [DataMember]
        public string SettlementDate { get; set; }


        [JsonProperty("SaleDelta")]
        [DataMember]
        public float SaleDelta { get; set; }


        [JsonProperty("ReloadDelta")]
        [DataMember]
        public float ReloadDelta { get; set; }
         
    }



    public class MerchantERPReloadSaleEarningDetailModelInput : BaseClass
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

    public class MerchantERPReloadSaleEarningDetailModelOutput
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


        [JsonProperty("Sale")]
        [DataMember]
        public float Sale { get; set; }


        [JsonProperty("Reload")]
        [DataMember]
        public float Reload { get; set; }

        [JsonProperty("Earning")]
        [DataMember]
        public float Earning { get; set; }

    }
}
