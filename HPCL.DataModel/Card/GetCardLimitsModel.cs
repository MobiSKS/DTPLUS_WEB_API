using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class GetCardLimitsModelInput : BaseClass
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
        [JsonPropertyName("Statusflag")]
        [DataMember]
        public Int32 Statusflag { get; set; }

    }
    public class GetCardLimitsModelOutput
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


        [JsonProperty("CashPurseLimit")]
        [DataMember]
        public float CashPurseLimit { get; set; }

        [JsonProperty("SaleTxnLimit")]
        [DataMember]
        public float SaleTxnLimit { get; set; }

        [JsonProperty("DailySaleLimit")]
        [DataMember]
        public float DailySaleLimit { get; set; }

        [JsonProperty("MonthlySaleLimit")]
        [DataMember]
        public float MonthlySaleLimit { get; set; }

    }


    public class ViewCardLimitsModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public string Customerid { get; set; }
         
    }

    public class ViewCardLimitsModelOutput
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


        [JsonProperty("MobileNumber")]
        [DataMember]
        public string MobileNumber { get; set; }


        [JsonProperty("DailySaleLimit")]
        [DataMember]
        public float DailySaleLimit { get; set; }


        [JsonProperty("DailySaleBal")]
        [DataMember]
        public float DailySaleBal { get; set; }


        [JsonProperty("MonthlySaleLimit")]
        [DataMember]
        public float MonthlySaleLimit { get; set; }


        [JsonProperty("MonthlySaleBal")]
        [DataMember]
        public float MonthlySaleBal { get; set; }


        [JsonProperty("CCMSLimit")]
        [DataMember]
        public float CCMSLimit { get; set; }

        [JsonProperty("LimitType")]
        [DataMember]
        public string LimitType { get; set; }


        [JsonProperty("AvailableCCMSLimit")]
        [DataMember]
        public float AvailableCCMSLimit { get; set; }


    }


}
