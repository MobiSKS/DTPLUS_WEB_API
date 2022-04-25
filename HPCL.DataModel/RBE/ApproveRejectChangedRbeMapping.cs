using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.RBE
{
    public class ApproveRejectChangedRbeMappingModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("PreRBEUserName")]
        [DataMember]
        public string PreRBEUserName { get; set; }

        [Required]
        [JsonPropertyName("MappingStatus")]
        [DataMember]
        public string MappingStatus { get; set; }
        
    }
    public class ApproveRejectChangedRbeMappingModelOutput : BaseClassOutput
    {
        
    }
}
