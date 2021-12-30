using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HPCL.Infrastructure.TokenManager
{
    public class GenerateTokenInput
    {

        [Required]
        [JsonProperty("Useragent")]
        public string Useragent { get; set; }

        [Required]
        [JsonProperty("Userip")]
        public string Userip { get; set; }

        [Required]
        [JsonProperty("Userid")]
        public string Userid { get; set; }

    }
}
