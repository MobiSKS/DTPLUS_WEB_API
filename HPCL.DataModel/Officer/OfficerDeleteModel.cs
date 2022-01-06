using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Officer
{
        
    public class DeleteOfficerModelInput : BaseClass
    {
        [Required]
        [JsonProperty("OfficerId")]
        [DataMember]
        public int OfficerId { get; set; }

        [Required]
        [JsonProperty("ModifiedBy")]
        [DataMember]
        public int ModifiedBy { get; set; }
    }

    public class DeleteOfficerModelOutput : BaseClassOutput
    {

    }

    
}
