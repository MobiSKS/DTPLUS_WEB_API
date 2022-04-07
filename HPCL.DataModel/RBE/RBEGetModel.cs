using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.RBE
{
    public class RBEGetModelInput : BaseClass
    {
        [JsonPropertyName("RBEId")]
        [DataMember]
        public string RBEId { get; set; }
    }

    public class RBEGetModelOutput : BaseClassOutput
    {
        [JsonProperty("RBEId")]
        [DataMember]
        public string RBEId { get; set; }

        [JsonProperty("RBEName")]
        [DataMember]
        public string RBEName { get; set; }
    }
}
