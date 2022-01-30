using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class UpdateCCMSLimitsModelInput : BaseClass
    {

        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Onetime")]
        [DataMember]
        public float Onetime { get; set; }

        [Required]
        [JsonPropertyName("Daily")]
        [DataMember]
        public int Daily { get; set; }

        [Required]
        [JsonPropertyName("Monthly")]
        [DataMember]
        public int Monthly { get; set; }


        [Required]
        [JsonPropertyName("Yearly")]
        [DataMember]
        public int Yearly { get; set; }


        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }
    }

    public class UpdateCCMSLimitsModelOutput : BaseClassOutput
    {

    }

}
