﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
namespace HPCL.DataModel.Card
{
    public class GetCardLimtModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }
    }

    public class GetCardLimtModelOutput
    {
        [JsonProperty("GetCardsDetailsModelOutput")]
        public List<GetCardsDetailsModelOutput> GetCardsDetails { get; set; }

        [JsonProperty("GetCardLimtModel")]
        public List<CardLimtModelOutput> GetCardLimt { get; set; }

        //[JsonProperty("CardReminingLimt")]
        //public List<CardReminingLimtModelOutput> CardReminingLimt { get; set; }

        //[JsonProperty("CardReminingCCMSLimt")]
        //public List<CardReminingCCMSLimtModelOutput> CardReminingCCMSLimt { get; set; }

        [JsonProperty("CardServices")]
        public List<CardServicesModelOutput> CardServices { get; set; }
    }

    public class CardLimtModelOutput
    {
         
        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        //[Required]
        [JsonProperty("CardBalance")]
        [DataMember]
        public float CardBalance { get; set; }


        //[Required]
        [JsonProperty("CardStatus")]
        [DataMember]
        public string CardStatus { get; set; }


        //[Required]
        [JsonProperty("SaleTranscationLimit")]
        [DataMember]
        public float SaleTranscationLimit { get; set; }


        //[Required]
        [JsonProperty("DailySaleLimit")]
        [DataMember]
        public float DailySaleLimit { get; set; }


        //[Required]
        [JsonProperty("DailyCreditLimit")]
        [DataMember]
        public float DailyCreditLimit { get; set; }

        //[Required]
        [JsonProperty("CashPurseLimit")]
        [DataMember]
        public float CashPurseLimit { get; set; }

        //[Required]
        [JsonProperty("MonthlySaleLimit")]
        [DataMember]
        public float MonthlySaleLimit { get; set; }

        //[Required]
        [JsonProperty("MonthlySaleBalance")]
        [DataMember]
        public float MonthlySaleBalance { get; set; }

        //[Required]
        [JsonProperty("CCMSReloadSale")]
        [DataMember]
        public float CCMSReloadSale { get; set; }


        //[Required]
        [JsonProperty("CCMSReloadSaleLimit")]
        [DataMember]
        public string CCMSReloadSaleLimit { get; set; }


        [JsonProperty("CCMSReloadSaleLimitValue")]
        [DataMember]
        public float CCMSReloadSaleLimitValue { get; set; }

        [JsonProperty("ExpiryDate")]
        [DataMember]
        public DateTime ExpiryDate { get; set; }

        [JsonProperty("AllowCreditTranscation")]
        [DataMember]
        public string AllowCreditTranscation { get; set; }


    }

    //public class CardReminingLimtModelOutput
    //{

    //    //[Required]
    //    [JsonProperty("RemCardDaily")]
    //    [DataMember]
    //    public float RemCardDaily { get; set; }

    //    //[Required]
    //    [JsonProperty("RemCardMonthly")]
    //    [DataMember]
    //    public float RemCardMonthly { get; set; }

    //    //[Required]
    //    [JsonProperty("RemCardYearly")]
    //    [DataMember]
    //    public float RemCardYearly { get; set; }

    //}

    //public class CardReminingCCMSLimtModelOutput
    //{

    //    //[Required]
    //    [JsonProperty("RemCCMSDaily")]
    //    [DataMember]
    //    public float RemCCMSDaily { get; set; }

    //    //[Required]
    //    [JsonProperty("RemCCMSMonthly")]
    //    [DataMember]
    //    public float RemCCMSMonthly { get; set; }

    //    //[Required]
    //    [JsonProperty("RemCCMSYearly")]
    //    [DataMember]
    //    public float RemCCMSYearly { get; set; }

    //}

    public class CardServicesModelOutput
    {

        //[Required]
        [JsonProperty("ServiceID")]
        [DataMember]
        public int ServiceID { get; set; }

        //[Required]
        [JsonProperty("ServiceName")]
        [DataMember]
        public string ServiceName { get; set; }

        //[Required]
        [JsonProperty("SelectedServices")]
        [DataMember]
        public int SelectedServices { get; set; }

    }


    public class GetCardsDetailsModelOutput
    {
        [JsonProperty("SrNumber")]
        [DataMember]
        public int SrNumber { get; set; }

        [JsonProperty("CardNumber")]
        [DataMember]
        public string CardNumber { get; set; }


        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [JsonProperty("UserID")]
        [DataMember]
        public string UserID { get; set; }

        [JsonProperty("RequestDate")]
        [DataMember]
        public string RequestDate { get; set; }


        [JsonProperty("OwnedorAttachedId")]
        [DataMember]
        public Int32 OwnedorAttachedId { get; set; }


        [JsonProperty("OwnedorAttached")]
        [DataMember]
        public string OwnedorAttached { get; set; }


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


        [JsonProperty("Manufacturer")]
        [DataMember]
        public string Manufacturer { get; set; }


        [JsonProperty("MobileNumber")]
        [DataMember]
        public string MobileNumber { get; set; }

        [JsonProperty("VINNumber")]
        [DataMember]
        public string VINNumber { get; set; }


        [JsonProperty("VehicleMake")]
        [DataMember]
        public string VehicleMake { get; set; }

        [JsonProperty("OwnershipType")]
        [DataMember]
        public string OwnershipType { get; set; }

        [JsonProperty("FormNumber")]
        [DataMember]
        public string FormNumber { get; set; }

        [JsonProperty("CardCategory")]
        [DataMember]
        public string CardCategory { get; set; }

        [JsonProperty("CardIssueType")]
        [DataMember]
        public string CardIssueType { get; set; }

        [JsonProperty("CardIdentifier")]
        [DataMember]
        public string CardIdentifier { get; set; }
    }
}



