using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CustomerGetTransactionsSummaryModelInput : BaseClass
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

        [JsonPropertyName("FromDate")]
        [DataMember]
        public string FromDate { get; set; }

        [JsonPropertyName("ToDate")]
        [DataMember]
        public string ToDate { get; set; }
    }

    public class CustomerGetTransactionsSummaryModelOutput
    {
        [JsonProperty("GetTransactionsSaleSummary")]
        public List<CustomerGetTransactionsSaleSummaryModelOutput> GetTransactionsSaleSummary { get; set; }

        [JsonProperty("GetTransactionsDetailSummary")]
        public List<CustomerGetTransactionsDetailSummaryModelOutput> GetTransactionsDetailSummary { get; set; }
    }

    public class CustomerGetTransactionsSaleSummaryModelOutput
    {
        [JsonProperty("AccountNumber")]
        [DataMember]
        public string AccountNumber { get; set; }

        [JsonProperty("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }

        [JsonProperty("Sale")]
        [DataMember]
        public double Sale { get; set; }

        [JsonProperty("ReloadCcmsCash")]
        [DataMember]
        public double ReloadCcmsCash { get; set; }

        [JsonProperty("CcmsRecharge")]
        [DataMember]
        public double CcmsRecharge { get; set; }

    }

    public class CustomerGetTransactionsDetailSummaryModelOutput
    {
        [JsonProperty("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }

        [JsonProperty("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }

        [JsonProperty("AccountNumber")]
        [DataMember]
        public string AccountNumber { get; set; }

        [JsonProperty("VechileNo")]
        [DataMember]
        public string VechileNo { get; set; }

        [JsonProperty("TxnDate")]
        [DataMember]
        public string TxnDate { get; set; }

        [JsonProperty("TxnType")]
        [DataMember]
        public string TxnType { get; set; }

        [JsonProperty("ProductName")]
        [DataMember]
        public string ProductName { get; set; }

        [JsonProperty("Price")]
        [DataMember]
        public double Price { get; set; }

        [JsonProperty("Volume")]
        [DataMember]
        public double Volume { get; set; }

        [JsonProperty("Currency")]
        [DataMember]
        public string Currency { get; set; }

        [JsonProperty("ServiceCharge")]
        [DataMember]
        public double ServiceCharge { get; set; }

        [JsonProperty("Amount")]
        [DataMember]
        public double Amount { get; set; }


        [JsonProperty("Discount")]
        [DataMember]
        public double Discount { get; set; }

        [JsonProperty("OdometerReading")]
        [DataMember]
        public string OdometerReading { get; set; }

        [JsonProperty("Status")]
        [DataMember]
        public string Status { get; set; }
    }
}
