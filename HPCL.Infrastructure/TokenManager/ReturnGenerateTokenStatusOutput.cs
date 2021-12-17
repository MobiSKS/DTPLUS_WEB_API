using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http.ModelBinding;

namespace HPCL.Infrastructure.TokenManager
{

    public class ReturnGenerateTokenStatusOutput
    {

        [JsonProperty("Success")]
        public bool Success { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Status_Code")]
        public Int64 Status_Code { get; set; }

        [JsonProperty("Method_Name")]
        public string Method_Name { get; set; }

        [JsonProperty("Token")]
        public string Token { get; set; }

        [JsonProperty("Model_State")]
        public ModelStateDictionary Model_State { get; set; }
    }
}
