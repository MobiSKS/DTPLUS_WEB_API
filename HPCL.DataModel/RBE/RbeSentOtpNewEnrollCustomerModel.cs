using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.RBE
{
    public class RbeSentOtpNewEnrollCustomerModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }

        [Required]
        [JsonPropertyName("RBEMobileNo")]
        [DataMember]
        public string RBEMobileNo { get; set; }
    }
    public class RbeSentOtpNewEnrollCustomerModelOutput : BaseClassOutput
    {

        [JsonProperty("OTP")]
        [DataMember]
        public string OTP { get; set; }
    }
}
