using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.RBE
{
    public class RBEApprovalRejectModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("UserName")]
        [DataMember]
        public string UserName { get; set; }

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

    public class RBEApprovalRejectApprovalModelOutput : BaseClassOutput
    {
        [Required]
        [JsonProperty("FirstName")]
        [DataMember]
        public string FirstName { get; set; }

        [Required]
        [JsonProperty("LastName")]
        [DataMember]
        public string LastName { get; set; }

        [Required]
        [JsonProperty("EmailId")]
        [DataMember]
        public string EmailId { get; set; }

        [Required]
        [JsonProperty("RBEOTP")]
        [DataMember]
        public string RBEOTP { get; set; }
    }
}
