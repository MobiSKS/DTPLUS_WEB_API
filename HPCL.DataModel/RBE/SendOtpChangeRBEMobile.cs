using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.RBE
{
    internal class SendOtpChangeRBEMobile
    {
    }

    public class SendOtpChangeRBEMobileModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("NewMobileNo")]
        [DataMember]
        public string @NewMobileNo { get; set; }

        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }

    public class SendOtpChangeRBEMobileModelOutput : BaseClassOutput
    {

        [JsonProperty("OTP")]
        [DataMember]
        public string OTP { get; set; }
    }
}
