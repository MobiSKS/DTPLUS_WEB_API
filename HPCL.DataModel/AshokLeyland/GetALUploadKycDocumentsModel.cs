using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.AshokLeyland
{
   public class GetALUploadKycDocumentsModelInput : BaseClass
    {
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

    }
    public class GetALUploadKycDocumentsModelOutput : BaseClassOutput
    {
        [JsonProperty("IdProofType")]
        [DataMember]
        public string IdProofType { get; set; }

        [JsonProperty("IdProofName")]
        [DataMember]
        public string IdProofName { get; set; }

        [JsonProperty("FileName")]
        [DataMember]
        public string FileName { get; set; }
    }

}
