using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class GetDetailForCorpMultiRechargeLimitConfigModelInput
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }

    public class GetDetailForCorpMultiRechargeLimitConfigModelOutput:BaseClassOutput
    {       
        [JsonProperty("LimitId")]
        [DataMember]
        public int LimitId { get; set; }

        [JsonProperty("TypeOfLimit")]
        [DataMember]
        public string TypeOfLimit { get; set; }

        [JsonProperty("CheckUncheckId")]
        [DataMember]
        public int CheckUncheckId { get; set; }
    }
}
