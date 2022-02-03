using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    
    public class UpdateCCMSLimitForAllCardsModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public string CustomerID { get; set; }

        [Required]
        [JsonPropertyName("Limittype")]
        [DataMember]
        public int Limittype { get; set; }

        [Required]
        [JsonPropertyName("Amount")]
        [DataMember]
        public float Amount { get; set; }

        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }
    }

    public class UpdateCCMSLimitForAllCardsModelOutput : BaseClassOutput
    {

    }
}
