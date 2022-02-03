using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class UpdateCardLimitForAllCardsModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public string CustomerID { get; set; }

        [Required]
        [JsonPropertyName("Statusflag")]
        [DataMember]
        public int Statusflag { get; set; }

        [Required]
        [JsonPropertyName("Limitid")]
        [DataMember]
        public int Limitid { get; set; }

        [Required]
        [JsonPropertyName("Limit")]
        [DataMember]
        public float Limit { get; set; }

        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }
    }

    public class UpdateCardLimitForAllCardsModelOutput : BaseClassOutput
    {

    }
}
