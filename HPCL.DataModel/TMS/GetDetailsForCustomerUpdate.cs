using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.TMS
{
    public class GetDetailsForCustomerUpdateModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }
    }
    public class GetDetailsForCustomerUpdateModelOutput
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }

        [JsonProperty("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }

        [JsonProperty("CommunicationAddress1")]
        [DataMember]
        public string CommunicationAddress1 { get; set; }

        [JsonProperty("CommunicationAddress2")]
        [DataMember]
        public string CommunicationAddress2 { get; set; }

        [JsonProperty("CommunicationAddress3")]
        [DataMember]
        public string CommunicationAddress3 { get; set; }

        [JsonProperty("CommunicationCityName")]
        [DataMember]
        public string CommunicationCityName { get; set; }


        [JsonProperty("CommunicationPincode")]
        [DataMember]
        public string CommunicationPincode { get; set; }

        [JsonProperty("CommunicationState")]
        [DataMember]
        public string CommunicationState { get; set; }

        [JsonProperty("CommunicationDistrict")]
        [DataMember]
        public string CommunicationDistrict { get; set; }

        [JsonProperty("CommunicationPhoneNo")]
        [DataMember]
        public string CommunicationPhoneNo { get; set; }

        [JsonProperty("CommunicationMobileNo")]
        [DataMember]
        public string CommunicationMobileNo { get; set; }

        [JsonProperty("CommunicationFax")]
        [DataMember]
        public string CommunicationFax { get; set; }

        [JsonProperty("CommunicationEmailid")]
        [DataMember]
        public string CommunicationEmailid { get; set; }

        [JsonProperty("IncomeTaxPan")]
        [DataMember]
        public string IncomeTaxPan { get; set; }

        [JsonProperty("PermanentAddress1")]
        [DataMember]
        public string PermanentAddress1 { get; set; }

        [JsonProperty("PermanentAddress2")]
        [DataMember]
        public string PermanentAddress2 { get; set; }

        [JsonProperty("PermanentAddress3")]
        [DataMember]
        public string PermanentAddress3 { get; set; }

        [JsonProperty("PermanentLocation")]
        [DataMember]
        public string PermanentLocation { get; set; }

        [JsonProperty("PermanentCityName")]
        [DataMember]
        public string PermanentCityName { get; set; }

        [JsonProperty("PermanentPincode")]
        [DataMember]
        public string PermanentPincode { get; set; }

        [JsonProperty("PermanentState")]
        [DataMember]
        public string PermanentState { get; set; }

        [JsonProperty("PermanentDistrict")]
        [DataMember]
        public string PermanentDistrict { get; set; }

        [JsonProperty("PermanentPhoneNo")]
        [DataMember]
        public string PermanentPhoneNo { get; set; }

        [JsonProperty("PermanentFax")]
        [DataMember]
        public string PermanentFax { get; set; }

    }
}
