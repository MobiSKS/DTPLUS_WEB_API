using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class UpdateCCMSLimitsModelInput : BaseClass
    {

        //[Required]
        //[JsonPropertyName("Cardno")]
        //[DataMember]
        //public string Cardno { get; set; }

        //[Required]
        //[JsonPropertyName("Limittype")]
        //[DataMember]
        //public int Limittype { get; set; }

        //[Required]
        //[JsonPropertyName("Amount")]
        //[DataMember]
        //public float Amount { get; set; }

        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }

        [JsonPropertyName("ObjCCMSLimits")]
        [DataMember]
        public List<CCMSLimitsModelInput> ObjCCMSLimits { get; set; }
    }

    public class CCMSLimitsModelInput 
    {

        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Limittype")]
        [DataMember]
        public int Limittype { get; set; }

        [Required]
        [JsonPropertyName("Amount")]
        [DataMember]
        public float Amount { get; set; }
 
    }

    public class UpdateCCMSLimitsModelOutput : BaseClassOutput
    {

    }

}
