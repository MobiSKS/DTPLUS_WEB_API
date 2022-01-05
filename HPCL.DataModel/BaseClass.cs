﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HPCL.DataModel
{
    public abstract class BaseClass
    {
        [Required]
        [JsonProperty("Userid")]
        [DataMember]
        public string Userid { get; set; }

        [Required]
        [JsonProperty("Useragent")]
        [DataMember]
        public string Useragent { get; set; }

        [Required]
        [JsonProperty("Userip")]
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
