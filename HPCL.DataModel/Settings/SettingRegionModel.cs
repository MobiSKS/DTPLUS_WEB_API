using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetRegionModelInput : BaseClass
    {
        [JsonPropertyName("ZoneID")]
        [DataMember]
        public int ZoneID { get; set; }
    }
    public class SettingGetRegionModelOutput
    {
        [JsonProperty("ZoneID")]
        [DataMember]
        public int ZoneID { get; set; }

        [JsonProperty("RegionID")]
        [DataMember]
        public int RegionID { get; set; }

        [JsonProperty("RegionName")]
        [DataMember]
        public string RegionName { get; set; }

        [JsonProperty("RegionShortName")]
        [DataMember]
        public string RegionShortName { get; set; }
    }



}
