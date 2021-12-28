using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace HPCL.DataModel
{
    public abstract class BaseClass
    {
        [JsonProperty("Userid")]
        [DataMember]
        public string Userid { get; set; }

        [JsonProperty("Useragent")]
        [DataMember]
        public string Useragent { get; set; }

        [JsonProperty("Userip")]
        [DataMember]
        public string Userip { get; set; }
    }
}
