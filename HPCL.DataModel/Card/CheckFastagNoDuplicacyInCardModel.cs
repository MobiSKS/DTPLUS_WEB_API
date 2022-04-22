using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.Card
{
    public class CheckFastagNoDuplicacyInCardModelInput:BaseClass
    {
        [Required]
        [JsonPropertyName("FastagNo")]
        [DataMember]
        public string FastagNo { get; set; }
    }

    public class CheckFastagNoDuplicacyInCardModelOutput:BaseClassOutput
    {
    }
}
