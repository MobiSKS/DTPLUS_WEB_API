using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class GetControlCardNumberModelInput : BaseClass
    {
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }

    public class GetControlCardNumberModelOutput
    {
        [JsonProperty("ZonalOfficeName")]
        [DataMember]
        public string ZonalOfficeName { get; set; }


        [JsonProperty("RegionalOfficeName")]
        [DataMember]
        public string RegionalOfficeName { get; set; }

        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [JsonProperty("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }

        [JsonProperty("ControlCardNo")]
        [DataMember]
        public string ControlCardNo { get; set; }


    }
}
