﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class ManageSearchCardsModelInput : BaseClass
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
        [JsonPropertyName("Vehiclenumber")]
        [DataMember]
        public string Vehiclenumber { get; set; }


        //[Required]
        [JsonPropertyName("Statusflag")]
        [DataMember]
        public int Statusflag { get; set; }

    }

    public class ManageSearchCardsModelOutput
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

        [JsonProperty("LimitTypeId")]
        [DataMember]
        public Int32 LimitTypeId { get; set; }

        [JsonProperty("LimitTypeName")]
        [DataMember]
        public string LimitTypeName { get; set; }

        [JsonProperty("CCMSReloadSaleLimitValue")]
        [DataMember]
        public float CCMSReloadSaleLimitValue { get; set; }
    }

    public class BindPendingCustomerforCardModelInput : BaseClass
    {

        [JsonPropertyName("StateId")]
        [DataMember]
        public string StateId { get; set; }

        [JsonPropertyName("FormNumber")]
        [DataMember]
        public string FormNumber { get; set; }


        [JsonPropertyName("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }

        [JsonPropertyName("Createdon")]
        [DataMember]
        public string Createdon { get; set; }


        [JsonPropertyName("Createdby")]
        [DataMember]
        public string Createdby { get; set; }


    }

    public class BindPendingCustomerforCardModelOutput
    {


        [JsonProperty("FormNumber")]
        [DataMember]
        public Int64 FormNumber { get; set; }


        [JsonProperty("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }


        [JsonProperty("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }


        [JsonProperty("CustomerAddress")]
        [DataMember]
        public string CustomerAddress { get; set; }


        [JsonProperty("PhoneNo")]
        [DataMember]
        public string PhoneNo { get; set; }


        [JsonProperty("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }


        [JsonProperty("TotalCards")]
        [DataMember]
        public Int32 TotalCards { get; set; }


        [JsonProperty("CreatedRoleId")]
        [DataMember]
        public Int32 CreatedRoleId { get; set; }


        [JsonProperty("CreatedRoleName")]
        [DataMember]
        public string CreatedRoleName { get; set; }


        [JsonProperty("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }


        [JsonProperty("CreatedDate")]
        [DataMember]
        public string CreatedDate { get; set; }


        [JsonProperty("StatusId")]
        [DataMember]
        public Int32 StatusId { get; set; }



        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }


        [JsonProperty("KYCStatus")]
        [DataMember]
        public string KYCStatus { get; set; }


    }


    public class GetCardDetailForCardApprovalModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }
    }

    public class GetCardDetailForCardApprovalModelOutput
    {
        [JsonProperty("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }

        [JsonProperty("CardPreference")]
        [DataMember]
        public string CardPreference { get; set; }


        [JsonProperty("FeePaymentsCollectFeeWaiverId")]
        [DataMember]
        public Int16 FeePaymentsCollectFeeWaiverId { get; set; }


        [JsonProperty("FeePaymentsCollectorFeeWaiver")]
        [DataMember]
        public string FeePaymentsCollectorFeeWaiver { get; set; }


        [JsonProperty("FeePaymentNo")]
        [DataMember]
        public string FeePaymentNo { get; set; }


        [JsonProperty("FeePaymentDate")]
        [DataMember]
        public string FeePaymentDate { get; set; }


        [JsonProperty("CardIdentifier")]
        [DataMember]
        public string CardIdentifier { get; set; }


        [JsonProperty("VehicleType")]
        [DataMember]
        public string VehicleType { get; set; }


        [JsonProperty("VehicleMake")]
        [DataMember]
        public string VehicleMake { get; set; }


        [JsonProperty("YearOfRegistration")]
        [DataMember]
        public Int32 YearOfRegistration { get; set; }

        [JsonProperty("VechileOwnerName")]
        [DataMember]
        public string VechileOwnerName { get; set; }

        [JsonProperty("RBEId")]
        [DataMember]
        public string RBEId { get; set; }

        [JsonProperty("RbeName")]
        [DataMember]
        public string RbeName { get; set; }

        [JsonProperty("VechileNo")]
        [DataMember]
        public string VechileNo { get; set; }

    }
}
