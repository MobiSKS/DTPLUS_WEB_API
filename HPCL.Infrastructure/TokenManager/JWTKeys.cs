using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HPCL.Infrastructure.TokenManager
{
  public  class JWTKeys
    {

        [JsonProperty("StoreCode")]
        public string StoreCode { get; set; }

        [JsonProperty("SecretKey")]
        public string SecretKey { get; set; }

        [JsonProperty("API_Key")]
        public string API_Key { get; set; }
    }


}
