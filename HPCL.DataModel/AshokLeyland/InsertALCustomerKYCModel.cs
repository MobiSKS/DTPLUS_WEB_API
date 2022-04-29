using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.AshokLeyland
{

    public class InsertALCustomerKYCModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [Required]
        [JsonPropertyName("IdProofType")]
        [DataMember]
        public int IdProofType { get; set; }

        [Required]
        [JsonPropertyName("IdProofFront")]
        [DataMember]
        public string IdProofFront { get; set; }

        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }


    }
    public class InsertALCustomerKYCModelOutput : BaseClassOutput
    {
    }
}
