using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPCL.Infrastructure.TokenManager
{
    public class GenerateTokenInput
    {

        [JsonProperty("Useragent")]
        public string Useragent { get; set; }

        [JsonProperty("Userip")]
        public string Userip { get; set; }

        [JsonProperty("Userid")]
        public string Userid { get; set; }

    }
}
