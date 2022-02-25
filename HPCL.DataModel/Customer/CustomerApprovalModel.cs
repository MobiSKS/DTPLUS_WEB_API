﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CustomerApprovalModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public string CustomerReferenceNo { get; set; }

        [Required]
        [JsonPropertyName("Comments")]
        [DataMember]
        public string Comments { get; set; }
        

        [Required]
        [JsonPropertyName("Approvalstatus")]
        [DataMember]
        public Int32 Approvalstatus { get; set; }

        [Required]
        [JsonPropertyName("ApprovedBy")]
        [DataMember]
        public string ApprovedBy { get; set; }
    }

    public class CustomerApprovalModelOutput : BaseClassOutput
    {

        [JsonProperty("FirstName")]
        [DataMember]
        public string FirstName { get; set; }


        [JsonProperty("LastName")]
        [DataMember]
        public string LastName { get; set; }


        [JsonProperty("UserName")]
        [DataMember]
        public string UserName { get; set; }


        [JsonProperty("Password")]
        [DataMember]
        public string Password { get; set; }

        [JsonProperty("EmailId")]
        [DataMember]
        public string EmailId { get; set; }

        [JsonProperty("SendStatus")]
        [DataMember]
        public int SendStatus { get; set; }
    }


    public class CustomerFeewaiverApprovalModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }

        [Required]
        [JsonPropertyName("Comments")]
        [DataMember]
        public string Comments { get; set; }



        [Required]
        [JsonPropertyName("Approvalstatus")]
        [DataMember]
        public Int32 Approvalstatus { get; set; }

        [Required]
        [JsonPropertyName("ApprovedBy")]
        [DataMember]
        public string ApprovedBy { get; set; }
    }

    public class CustomerFeewaiverApprovalModelOutput : BaseClassOutput
    {

    }


    public class GetApproveFeeWaiverDetailModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }
    }


    public class GetApproveFeeWaiverDetailModelOutput
    {
        [JsonProperty("GetApproveFeeWaiverBasicDetail")]
        public List<GetApproveFeeWaiverBasicDetailModelOutput> GetApproveFeeWaiverBasicDetail { get; set; }

        [JsonProperty("GetApproveFeeWaiverCardDetail")]
        public List<GetApproveFeeWaiverCardDetailModelOutput> GetApproveFeeWaiverCardDetail { get; set; }
    }

    public class GetApproveFeeWaiverBasicDetailModelOutput  
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
        public DateTime FeePaymentDate { get; set; }


    }

    public class GetApproveFeeWaiverCardDetailModelOutput
    {

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

    }
}
