using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Officer
{
    public class OfficerLocationMappingModelInput : BaseClass
    {
         
        [Required]
        [JsonPropertyName("OfficerId")]
        [DataMember]
        public int OfficerId { get; set; }

        [Required]
        [JsonPropertyName("UserName")]
        [DataMember]
        public string UserName { get; set; }

        [JsonPropertyName("ZO")]
        [DataMember]
        public int ZO { get; set; }

        
        [JsonPropertyName("RO")]
        [DataMember]
        public int RO { get; set; }

        [Required]
        [JsonPropertyName("Createdby")]
        [DataMember]
        public string Createdby { get; set; }

    }

    public class OfficerLocationMappingModelOutput : BaseClassOutput
    {

    }

   
}
