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
        public Int32 RBEId { get; set; }

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

    }

    public class AddCardModelOutput : BaseClassOutput
    {

    }
}
