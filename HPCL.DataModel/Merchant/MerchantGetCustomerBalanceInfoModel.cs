using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
    public class MerchantGetCustomerBalanceInfoModelInput : BaseClass
    {
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }

    public class MerchantGetCustomerBalanceInfoModelOutput
    {
        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [JsonProperty("CardBalance")]
        [DataMember]
        public double CardBalance { get; set; }

        [JsonProperty("CCMSLimitValue")]
        [DataMember]
        public double CCMSLimitValue { get; set; }

        [JsonProperty("Drivestars")]
        [DataMember]
        public double Drivestars { get; set; }

        [JsonProperty("ExpiredDrivestars")]
        [DataMember]
        public double ExpiredDrivestars { get; set; }

        [JsonProperty("ExpiringDrivestars")]
        [DataMember]
        public double ExpiringDrivestars { get; set; }

        [JsonProperty("CashPurseLimit")]
        [DataMember]
        public double CashPurseLimit { get; set; }

        [JsonProperty("DailyCashLimitBalance")]
        [DataMember]
        public double DailyCashLimitBalance { get; set; }
    }
}
