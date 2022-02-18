using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{

    public class CustomerGetCustomerReferenceNoModelInput : BaseClass
    {
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }
    }

    public class CustomerGetCustomerReferenceNoModelOutput
    {
        [JsonProperty("Title")]
        [DataMember]
        public string KeyOfficialTitle { get; set; }

        [JsonProperty("FirstName")]
        [DataMember]
        public string KeyOfficialFirstName { get; set; }

        [JsonProperty("MiddleName")]
        [DataMember]
        public string KeyOfficialMiddleName { get; set; }

        [JsonProperty("LastName")]
        [DataMember]
        public string KeyOfficialLastName { get; set; }


        [JsonProperty("FormNumber")]
        [DataMember]
        public Int64 FormNumber { get; set; }

        [JsonProperty("CustomerTypeId")]
        [DataMember]
        public int CustomerTypeId { get; set; }

        [JsonProperty("CustomerTypeName")]
        [DataMember]
        public string CustomerTypeName { get; set; }

    }


    public class SendOTPConsentModelInput : BaseClass
    {
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }
    }

    public class SendOTPConsentModelOutput :BaseClassOutput
    {

        [JsonProperty("CustomerReferenceNo")]
        [DataMember]
        public string OTP { get; set; }
    }


    public class ValidateOTPConsentModelInput : BaseClass
    {
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }

        [JsonPropertyName("OTP")]
        [DataMember]
        public string OTP { get; set; }
    }

    public class ValidateOTPConsentModelOutput : BaseClassOutput
    {

    }
}
