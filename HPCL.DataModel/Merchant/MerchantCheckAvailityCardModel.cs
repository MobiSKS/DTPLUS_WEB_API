﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
    public class MerchantCheckAvailityCardInput : BaseClass
    {
        [JsonPropertyName("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

        //[JsonPropertyName("RegionalId")]
        //[DataMember]
        //public Int32 RegionalId { get; set; }
    }

    public class MerchantCheckAvailityCardOutput  
    {
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }


    public class MerchantGetAvailityCardInput : BaseClass
    {

        [JsonPropertyName("RegionalId")]
        [DataMember]
        public Int32 RegionalId { get; set; }
    }

    public class MerchantGetAvailityCardOutput
    {
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }

}
