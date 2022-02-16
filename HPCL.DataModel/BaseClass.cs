using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel
{
    public abstract class BaseClass
    {
        [Required]
        [JsonPropertyName("UserId")]
        [DataMember]
        public string Userid { get; set; }

        [Required]
        [JsonPropertyName("Useragent")]
        [DataMember]
        public string Useragent { get; set; }

        [Required]
        [JsonPropertyName("Userip")]
        [DataMember]
        public string Userip { get; set; }


       
    }

    public abstract class BaseClassOutput
    {
        [JsonProperty("Status")]
        [DataMember]
        public int Status { get; set; }

        [JsonProperty("Reason")]
        [DataMember]
        public string Reason { get; set; }
    }
}
