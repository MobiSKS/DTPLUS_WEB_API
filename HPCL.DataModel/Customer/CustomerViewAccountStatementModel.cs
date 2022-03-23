using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CustomerViewAccountStatementModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [Required]
        [JsonPropertyName("FromDate")]
        [DataMember]
        public string FromDate { get; set; }

        [Required]
        [JsonPropertyName("ToDate")]
        [DataMember]
        public string ToDate { get; set; }
    }

    public class CustomerViewAccountStatementModelOutput
    {
        [JsonProperty("GetCcmsAccountSummary")]
        public List<CcmsAccountSummaryModelOutput> GetCcmsAccountSummary { get; set; }

        [JsonProperty("GetCardTransactionDetails")]
        public List<CardTransactionDetailsModelOutput> GetCardTransactionDetails { get; set; }
    }

    public class CcmsAccountSummaryModelOutput
    {
        [JsonProperty("Credits")]
        [DataMember]
        public double Credits { get; set; }

        [JsonProperty("Debits")]
        [DataMember]
        public double Debits { get; set; }

        [JsonProperty("OpeningBalance")]
        [DataMember]
        public double OpeningBalance { get; set; }

        [JsonProperty("ClosingBalance")]
        [DataMember]
        public double ClosingBalance { get; set; }
    }
    public class CardTransactionDetailsModelOutput
    {
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

        [JsonProperty("VechileNo")]
        [DataMember]
        public string VechileNo { get; set; }

        [JsonProperty("TransactionType")]
        [DataMember]
        public string TransactionType { get; set; }

        [JsonProperty("Product")]
        [DataMember]
        public string Product { get; set; }

        [JsonProperty("Price")]
        [DataMember]
        public double Price { get; set; }

        [JsonProperty("Volume")]
        [DataMember]
        public double Volume { get; set; }

        [JsonProperty("Amount")]
        [DataMember]
        public double Amount { get; set; }

        [JsonProperty("RewardType")]
        [DataMember]
        public string RewardType { get; set; }

        [JsonProperty("Date")]
        [DataMember]
        public DateTime Date { get; set; }
    }
}
