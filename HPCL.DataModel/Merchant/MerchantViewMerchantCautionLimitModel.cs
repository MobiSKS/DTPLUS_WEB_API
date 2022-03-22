﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
    public class MerchantViewMerchantCautionLimitModelInput : BaseClass
    {
        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }

        [JsonPropertyName("MerchantStatus")]
        [DataMember]
        public string MerchantStatus { get; set; }

        [Required]
        [JsonPropertyName("FromDate")]
        [DataMember]
        public string FromDate { get; set; }

        [Required]
        [JsonPropertyName("ToDate")]
        [DataMember]
        public string ToDate { get; set; }

        [JsonPropertyName("RegionalOffice")]
        [DataMember]
        public string RegionalOffice { get; set; }

        [JsonPropertyName("SalesArea")]
        [DataMember]
        public string SalesArea { get; set; }
    }

    public class MerchantViewMerchantCautionLimitModelOutput
    {
        [JsonProperty("SrNumber")]
        [DataMember]
        public int SrNumber { get; set; }

        [JsonProperty("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }

        [JsonProperty("ErpCode")]
        [DataMember]
        public string ErpCode { get; set; }

        [JsonProperty("RetailOutletName")]
        [DataMember]
        public string RetailOutletName { get; set; }

        [JsonProperty("RegionalOfficeName")]
        [DataMember]
        public string RegionalOfficeName { get; set; }

        [JsonProperty("SalesArea")]
        [DataMember]
        public string SalesArea { get; set; }

        [JsonProperty("RetailOutletCity")]
        [DataMember]
        public string RetailOutletCity { get; set; }

        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }

        [JsonProperty("AvgHsdSale")]
        [DataMember]
        public double AvgHsdSale { get; set; }

        [JsonProperty("HsdRspValue")]
        [DataMember]
        public double HsdRspValue { get; set; }

        [JsonProperty("DtplusCautionLimit")]
        [DataMember]
        public double DtplusCautionLimit { get; set; }

        [JsonProperty("AvgMsSale")]
        [DataMember]
        public double AvgMsSale { get; set; }

        [JsonProperty("MsRspValue")]
        [DataMember]
        public double MsRspValue { get; set; }

        [JsonProperty("HpPayCautionLimit")]
        [DataMember]
        public double HpPayCautionLimit { get; set; }

        [JsonProperty("LastUpdatedOn")]
        [DataMember]
        public string LastUpdatedOn { get; set; }

    }
}
