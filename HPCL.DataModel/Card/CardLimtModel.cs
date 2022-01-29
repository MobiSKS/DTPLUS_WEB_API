using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
namespace HPCL.DataModel.Card
{
    public class CardLimtModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }
    }

    public class GetCardLimtModelOutput
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public Int64 CustomerID { get; set; }

        [Required]
        [JsonPropertyName("CardBalance")]
        [DataMember]
        public float CardBalance { get; set; }


        [Required]
        [JsonPropertyName("CardStatus")]
        [DataMember]
        public string CardStatus { get; set; }


        [Required]
        [JsonPropertyName("OneTimeTransactionLimit")]
        [DataMember]
        public float OneTimeTransactionLimit { get; set; }


        [Required]
        [JsonPropertyName("DailyTransactionLimit")]
        [DataMember]
        public float DailyTransactionLimit { get; set; }


        [Required]
        [JsonPropertyName("MonthlyTransactionLimit")]
        [DataMember]
        public float MonthlyTransactionLimit { get; set; }

        [Required]
        [JsonPropertyName("YearlyTransactionLimit")]
        [DataMember]
        public float YearlyTransactionLimit { get; set; }

        [Required]
        [JsonPropertyName("OneTimeCCMSTransactionLimit")]
        [DataMember]
        public float OneTimeCCMSTransactionLimit { get; set; }

        [Required]
        [JsonPropertyName("DailyCCMSTransactionLimit")]
        [DataMember]
        public float DailyCCMSTransactionLimit { get; set; }

        [Required]
        [JsonPropertyName("MonthlyCCMSTransactionLimit")]
        [DataMember]
        public float MonthlyCCMSTransactionLimit { get; set; }


        [Required]
        [JsonPropertyName("YearlyCCMSTransactionLimit")]
        [DataMember]
        public float YearlyCCMSTransactionLimit { get; set; }



       
    }

    public class CardReminingLimtModelOutput
    {

        [Required]
        [JsonPropertyName("RemCardDaily")]
        [DataMember]
        public float RemCardDaily { get; set; }

        [Required]
        [JsonPropertyName("RemCardMonthly")]
        [DataMember]
        public float RemCardMonthly { get; set; }

        [Required]
        [JsonPropertyName("RemCardYearly")]
        [DataMember]
        public float RemCardYearly { get; set; }

    }

    public class CardReminingCCMSLimtModelOutput
    {

        [Required]
        [JsonPropertyName("RemCCMSDaily")]
        [DataMember]
        public float RemCCMSDaily { get; set; }

        [Required]
        [JsonPropertyName("RemCCMSMonthly")]
        [DataMember]
        public float RemCCMSMonthly { get; set; }

        [Required]
        [JsonPropertyName("RemCCMSYearly")]
        [DataMember]
        public float RemCCMSYearly { get; set; }

    }

    public class CardServicesModelOutput
    {

        [Required]
        [JsonPropertyName("ServiceID")]
        [DataMember]
        public int ServiceID { get; set; }

        [Required]
        [JsonPropertyName("ServiceName")]
        [DataMember]
        public string ServiceName { get; set; }

        [Required]
        [JsonPropertyName("SelectedServices")]
        [DataMember]
        public int SelectedServices { get; set; }

    }

    public class CardLimtModelOutput
    {
        [JsonProperty("GetCardLimtModel")]
        public List<GetCardLimtModelOutput> GetCardLimtModel { get; set; }

        [JsonProperty("CardReminingLimt")]
        public List<CardReminingLimtModelOutput> CardReminingLimt { get; set; }

        [JsonProperty("CardReminingCCMSLimt")]
        public List<CardReminingCCMSLimtModelOutput> CardReminingCCMSLimt { get; set; }

        [JsonProperty("CardServices")]
        public List<CardServicesModelOutput> CardServices { get; set; }
    }
}



