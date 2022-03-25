using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Tatkal
{
    public class MapTatkalCardsToTatkalCustomerModelInput : BaseClass
    {
        [JsonPropertyName("RegionalId")]
        [DataMember]
        public string RegionalId { get; set; }
    }


    public class MapTatkalCardsToTatkalCustomerModelOutput
    {
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }
}
