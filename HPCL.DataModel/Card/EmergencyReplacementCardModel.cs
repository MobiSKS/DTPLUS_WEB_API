using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class EmergencyReplacementCardModelInput 
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }

    }

    public class EmergencyReplacementCardModelOutput : BaseClassOutput
    {      
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

    }
}
