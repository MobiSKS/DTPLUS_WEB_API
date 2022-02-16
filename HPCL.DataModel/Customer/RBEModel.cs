using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class RBEGetModelInput : BaseClass
    {
        [JsonPropertyName("RBEId")]
        [DataMember]
        public string RBEId { get; set; }
    }

    public class RBEGetModelOutput :BaseClassOutput
    {
        [JsonProperty("RBEId")]
        [DataMember]
        public string RBEId { get; set; }

        [JsonProperty("RBEName")]
        [DataMember]
        public string RBEName { get; set; }
    }

  
}
