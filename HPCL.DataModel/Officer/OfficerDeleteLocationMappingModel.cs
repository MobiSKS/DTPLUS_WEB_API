using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Officer
{
    public class OfficerDeleteLocationMappingModelInput : BaseClass
    {
         
        

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
        [JsonProperty("ModifiedBy")]
        [DataMember]
        public int ModifiedBy { get; set; }

       

    }

    public class OfficerDeleteLocationMappingModelOutput : BaseClassOutput
    {

    }

   
}
