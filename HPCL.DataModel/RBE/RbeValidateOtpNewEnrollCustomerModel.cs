using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.RBE
{
    public class RbeValidateOtpNewEnrollCustomerModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }

        [Required]
        [JsonPropertyName("RBEMobileNo")]
        [DataMember]
        public string RBEMobileNo { get; set; }

        [Required]
        [JsonPropertyName("OTP")]
        [DataMember]
        public string OTP { get; set; }

        [Required]
        [JsonPropertyName("DeviceId")]
        [DataMember]
        public string DeviceId { get; set; }
    }
    public class RbeValidateOtpNewEnrollCustomerModelOutput : BaseClassOutput
    {

        [JsonProperty("OTP")]
        [DataMember]
        public string OTP { get; set; }
    }
}
