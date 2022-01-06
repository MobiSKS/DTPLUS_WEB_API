using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Officer
{
    

    public class CheckOfficerModelInput : BaseClass
    {
        [Required]
        [JsonProperty("UserName")]
        [DataMember]
        public string UserName { get; set; }
    }

    public class CheckOfficerModelOutput : BaseClassOutput
    {

    }
}
