using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    

    public class GetLimitMasterModelInput : BaseClass
    {
        
    }
    public class GetLimitMasterModelOutput
    {
        [JsonProperty("LimitId")]
        [DataMember]
        public int LimitId { get; set; }

        [JsonProperty("Description")]
        [DataMember]
        public string Description { get; set; }

    }
}
