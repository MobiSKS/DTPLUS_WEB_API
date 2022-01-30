using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class UpdateServiveOnCardModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Customerid")]
        [DataMember]
        public Int64 Customerid { get; set; }

        [Required]
        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }

        [Required]
        [JsonPropertyName("Serviceid")]
        [DataMember]
        public string Serviceid { get; set; }

        [Required]
        [JsonPropertyName("Flag")]
        [DataMember]
        public int Flag { get; set; }


        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }

    public class UpdateServiveOnCardModelOutput : BaseClassOutput
    {

    }
}
