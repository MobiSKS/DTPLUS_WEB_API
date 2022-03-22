using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.District
{ 

    public class GetDistrictModelInput : BaseClass
    {
        [JsonPropertyName("StateID")]
        [DataMember]
        public int StateID { get; set; }
    }
    public class GetDistrictModelOutput
    {
        [JsonPropertyName("StateID")]
        [DataMember]
        public int StateID { get; set; }

        [JsonPropertyName("DistrictID")]
        [DataMember]
        public int DistrictID { get; set; }

        [JsonPropertyName("DistrictName")]
        [DataMember]
        public string DistrictName { get; set; }

        [JsonPropertyName("DistrictShortName")]
        [DataMember]
        public string DistrictShortName { get; set; }

        [JsonPropertyName("DistrictCode")]
        [DataMember]
        public string DistrictCode { get; set; }
    }
}
