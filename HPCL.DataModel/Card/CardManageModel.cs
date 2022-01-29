using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class UpdateMobileInCardModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }

        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }
    }

    public class UpdateMobileInCardModelOutput : BaseClassOutput
    {

    }

    public class UpdateServiveOnCardModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public Int64 Customerid { get; set; }

        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Serviceid")]
        [DataMember]
        public string Serviceid { get; set; }

        [Required]
        [JsonPropertyName("Flag")]
        [DataMember]
        public int Flag { get; set; }


        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }

    public class UpdateServiveOnCardModelOutput : BaseClassOutput
    {

    }


    public class UpdateCardLimitsModelInput : BaseClass
    {
        

        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Onetime")]
        [DataMember]
        public float Onetime { get; set; }

        [Required]
        [JsonPropertyName("Daily")]
        [DataMember]
        public int Daily { get; set; }

        [Required]
        [JsonPropertyName("Monthly")]
        [DataMember]
        public int Monthly { get; set; }


        [Required]
        [JsonPropertyName("Yearly")]
        [DataMember]
        public int Yearly { get; set; }


        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }
    }

    public class UpdateCardLimitsModelOutput : BaseClassOutput
    {

    }


    public class UpdateCCMSLimitsModelInput : BaseClass
    {


        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Onetime")]
        [DataMember]
        public float Onetime { get; set; }

        [Required]
        [JsonPropertyName("Daily")]
        [DataMember]
        public int Daily { get; set; }

        [Required]
        [JsonPropertyName("Monthly")]
        [DataMember]
        public int Monthly { get; set; }


        [Required]
        [JsonPropertyName("Yearly")]
        [DataMember]
        public int Yearly { get; set; }


        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }
    }

    public class UpdateCCMSLimitsModelOutput : BaseClassOutput
    {

    }


    public class GetCCMSLimitsModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public string Customerid { get; set; }


        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }


        [Required]
        [JsonPropertyName("Statusflag")]
        [DataMember]
        public string Statusflag { get; set; }

    }

    public class GetCCMSLimitsModelOutput
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


        [JsonProperty("OneTimeCCMSTransactionLimit")]
        [DataMember]
        public float OneTimeCCMSTransactionLimit { get; set; }

        [JsonProperty("DailyCCMSTransactionLimit")]
        [DataMember]
        public float DailyCCMSTransactionLimit { get; set; }

        [JsonProperty("MonthlyCCMSTransactionLimit")]
        [DataMember]
        public float MonthlyCCMSTransactionLimit { get; set; }

        [JsonProperty("YearlyCCMSTransactionLimit")]
        [DataMember]
        public float YearlyCCMSTransactionLimit { get; set; }

    }


    public class GetCardLimitsModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public Int64 Customerid { get; set; }


        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }


        [Required]
        [JsonPropertyName("Statusflag")]
        [DataMember]
        public string Statusflag { get; set; }

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


        [JsonProperty("OneTimeCCMSTransactionLimit")]
        [DataMember]
        public float OneTimeCCMSTransactionLimit { get; set; }

        [JsonProperty("DailyCCMSTransactionLimit")]
        [DataMember]
        public float DailyCCMSTransactionLimit { get; set; }

        [JsonProperty("MonthlyCCMSTransactionLimit")]
        [DataMember]
        public float MonthlyCCMSTransactionLimit { get; set; }

        [JsonProperty("YearlyCCMSTransactionLimit")]
        [DataMember]
        public float YearlyCCMSTransactionLimit { get; set; }

    }


}
