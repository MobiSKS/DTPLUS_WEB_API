using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.Infrastructure.TokenManager
{
    public class GenerateTokenInput
    {

        [Required]
        [JsonPropertyName("Useragent")]
        [DataMember]
        public string Useragent { get; set; }

        [Required]
        [JsonPropertyName("Userip")]
        public string Userip { get; set; }

        [Required]
        [JsonPropertyName("Userid")]
        public string Userid { get; set; }

    }
}
