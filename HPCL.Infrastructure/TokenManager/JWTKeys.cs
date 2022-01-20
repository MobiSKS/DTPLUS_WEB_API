using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.Infrastructure.TokenManager
{
  public  class JWTKeys
    {

        [JsonPropertyName("StoreCode")]
        public string StoreCode { get; set; }

        [JsonPropertyName("SecretKey")]
        public string SecretKey { get; set; }

        [JsonPropertyName("API_Key")]
        public string API_Key { get; set; }
    }


}
