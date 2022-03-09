using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Transaction
{
    public class TransactionGetRegistrationProcessModelInput :BaseClass
    {
        [Required]
        [JsonPropertyName("IACId")]
        [DataMember]
        public string IACId { get; set; }
    }

    public class TransactionGetRegistrationProcessModelOutput
    {
        [JsonProperty("ObjGetRegistrationProcessMerchant")]
        public List<TransactionGetRegistrationProcessMerchantModelOutput> ObjGetRegistrationProcessMerchant { get; set; }

        [JsonProperty("ObjGetRegistrationProcessTrans")]
        public List<TransactionGetRegistrationProcessTransModelOutput> ObjGetRegistrationProcessTrans { get; set; }

        [JsonProperty("ObjBanks")]
        public List<TransactionBanksModelOutput> ObjBanks { get; set; }

        [JsonProperty("ObjFormFactors")]
        public List<TransactionFormFactorsModelOutput> ObjFormFactors { get; set; }
    }

    public class TransactionGetRegistrationProcessMerchantModelOutput
    {
        [JsonProperty("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }

        [JsonProperty("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }

        [JsonProperty("MerchantName")]
        [DataMember]
        public string MerchantName { get; set; }

        [JsonProperty("MerchantLocation")]
        [DataMember]
        public string MerchantLocation { get; set; }

        [JsonProperty("Header1")]
        [DataMember]
        public string Header1 { get; set; }


        [JsonProperty("Header2")]
        [DataMember]
        public string Header2 { get; set; }


        [JsonProperty("Footer1")]
        [DataMember]
        public string Footer1 { get; set; }


        [JsonProperty("Footer2")]
        [DataMember]
        public string Footer2 { get; set; }

        [JsonProperty("BatchSaleLimit")]
        [DataMember]
        public double BatchSaleLimit { get; set; }

        [JsonProperty("BatchReloadLimit")]
        [DataMember]
        public double BatchReloadLimit { get; set; }

        [JsonProperty("BatchSize")]
        [DataMember]
        public Int32 BatchSize { get; set; }


        [JsonProperty("SettlementTime")]
        [DataMember]
        public Int32 SettlementTime { get; set; }


        [JsonProperty("RemoteDownload")]
        [DataMember]
        public string RemoteDownload { get; set; }


        [JsonProperty("URL")]
        [DataMember]
        public string URL { get; set; }


        [JsonProperty("BatchNo")]
        [DataMember]
        public string BatchNo { get; set; }

    }

    public class TransactionGetRegistrationProcessTransModelOutput
    {
        [JsonProperty("TransType")]
        [DataMember]
        public Int32 TransType { get; set; }

        [JsonProperty("TransName")]
        [DataMember]
        public string TransName { get; set; }

        [JsonProperty("MaxVal")]
        [DataMember]
        public Int32 MaxVal { get; set; }


        [JsonProperty("MinVal")]
        [DataMember]
        public Int32 MinVal { get; set; }
    }

    public class TransactionBanksModelOutput
    {
        [JsonProperty("Value")]
        [DataMember]
        public Int32 Value { get; set; }

        [JsonProperty("Name")]
        [DataMember]
        public string Name { get; set; }
        
    }

    public class TransactionFormFactorsModelOutput
    {
        [JsonProperty("Value")]
        [DataMember]
        public Int32 Value { get; set; }

        [JsonProperty("Name")]
        [DataMember]
        public string Name { get; set; }

    }
}
