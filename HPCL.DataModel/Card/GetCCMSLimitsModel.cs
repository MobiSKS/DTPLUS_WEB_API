﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
namespace HPCL.DataModel.Card
{
    public class GetCCMSLimitsModelInput : BaseClass
    {
        //[Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public string Customerid { get; set; }


        //[Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        //[Required]
        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }


        //[Required]
        [JsonPropertyName("VechileNo")]
        [DataMember]
        public string VechileNo { get; set; }

    }

    public class GetCCMSLimitsModelOutput
    {

        [JsonProperty("CCMSBalanceDetail")]
        public List<GetCCMSLimitsForAllCardsModelOutput> CCMSBalanceDetail { get; set; }

        [JsonProperty("CCMSBasicDetail")]
        public List<CCMSLimitsModelOutput> CCMSBasicDetail { get; set; }


        //[JsonProperty("ActualCCMSBalance")]
        //[DataMember]
        //public float ActualCCMSBalance { get; set; }


        //[JsonProperty("UnallocatedCCMSBalance")]
        //[DataMember]
        //public float UnallocatedCCMSBalance { get; set; }

    }

    public class CCMSLimitsModelOutput
    {
        [JsonProperty("SrNumber")]
        [DataMember]
        public int SrNumber { get; set; }

        [JsonProperty("CardNumber")]
        [DataMember]
        public string CardNumber { get; set; }


        [JsonProperty("VechileNo")]
        [DataMember]
        public string VechileNo { get; set; }


        [JsonProperty("VehicleType")]
        [DataMember]
        public string VehicleType { get; set; }


        [JsonProperty("IssueDate")]
        [DataMember]
        public DateTime IssueDate { get; set; }


        [JsonProperty("ExpiryDate")]
        [DataMember]
        public DateTime ExpiryDate { get; set; }


        [JsonProperty("Status")]
        [DataMember]
        public string Status { get; set; }


        [JsonProperty("YearOfRegistration")]
        [DataMember]
        public Int32 YearOfRegistration { get; set; }


        [JsonProperty("MobileNumber")]
        [DataMember]
        public string MobileNumber { get; set; }

        [JsonProperty("VehicleMake")]
        [DataMember]
        public string VehicleMake { get; set; }


        [JsonProperty("CCMSLimitOption")]
        [DataMember]
        public Int32 CCMSLimitOption { get; set; }

        [JsonProperty("Description")]
        [DataMember]
        public string Description { get; set; }

        [JsonProperty("CCMSReloadSaleLimitValue")]
        [DataMember]
        public float CCMSReloadSaleLimitValue { get; set; }
    }
    public class GetCCMSLimitsForAllCardsModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public string Customerid { get; set; }

        [JsonPropertyName("Statusflag")]
        [DataMember]
        public Int32 Statusflag { get; set; }
    }

    public class GetCCMSLimitsForAllCardsModelOutput
    {
        [JsonProperty("ActualCCMSBalance")]
        [DataMember]
        public float ActualCCMSBalance { get; set; }


        [JsonProperty("UnallocatedCCMSBalance")]
        [DataMember]
        public float UnallocatedCCMSBalance { get; set; }

        [JsonProperty("CCMSUnlimitedStatus")]
        [DataMember]
        public int CCMSUnlimitedStatus { get; set; }

    }
}
