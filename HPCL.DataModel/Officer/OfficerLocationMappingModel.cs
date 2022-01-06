using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Officer
{
    public class OfficerLocationMappingModelInput : BaseClass
    {
         
        [Required]
        [JsonProperty("OfficerId")]
        [DataMember]
        public int OfficerId { get; set; }

        [Required]
        [JsonProperty("UserName")]
        [DataMember]
        public string UserName { get; set; }

        [JsonProperty("ZO")]
        [DataMember]
        public int ZO { get; set; }

        
        [JsonProperty("RO")]
        [DataMember]
        public int RO { get; set; }

        [Required]
        [JsonProperty("Createdby")]
        [DataMember]
        public int Createdby { get; set; }

       

    }

    public class OfficerLocationMappingModelOutput : BaseClassOutput
    {

    }

   
}
