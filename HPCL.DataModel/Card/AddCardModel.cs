using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class AddCardModelInput : BaseClass
    {
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }

        [JsonPropertyName("NoOfCards")]
        [DataMember]
        public Int32 NoOfCards { get; set; }

        [JsonPropertyName("RBEId")]
        [DataMember]
        public string RBEId { get; set; }

        [JsonPropertyName("FeePaymentsCollectFeeWaiver")]
        [DataMember]
        public Int16 FeePaymentsCollectFeeWaiver { get; set; }


        [JsonPropertyName("FeePaymentNo")]
        [DataMember]
        public string FeePaymentNo { get; set; }


        [JsonPropertyName("FeePaymentDate")]
        [DataMember]
        public DateTime FeePaymentDate { get; set; }

        [JsonPropertyName("ObjCardDetail")]
        [DataMember]
        public List<CardDetail> ObjCardDetail { get; set; }

        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }

        [JsonPropertyName("CardPreference")]
        [DataMember]
        public string CardPreference { get; set; }

        [JsonPropertyName("NoofVechileforAllCards")]
        [DataMember]
        public Int32 NoofVechileforAllCards { get; set; }
    }

    public class CardDetail
    {
        [JsonPropertyName("CardIdentifier")]
        public string CardIdentifier { get; set; }

        [JsonPropertyName("VechileNo")]
        public string VechileNo { get; set; }

        [JsonPropertyName("VehicleType")]
        public string VehicleType { get; set; }

        [JsonPropertyName("VehicleMake")]
        public string VehicleMake { get; set; }

        [JsonPropertyName("YearOfRegistration")]
        public int YearOfRegistration { get; set; }

        [JsonPropertyName("MobileNo")]
        public string MobileNo { get; set; }


    }

    public class AddCardModelOutput : BaseClassOutput
    {

    }

    public class ApproveRejectCardModelInput : BaseClass
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
    public class ApproveRejectCardModelOutput : BaseClassOutput
    {

    }
}
