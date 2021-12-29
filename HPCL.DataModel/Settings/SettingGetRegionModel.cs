using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetRegionModelInput : BaseClass
    {
        [JsonProperty("ZoneID")]
        [DataMember]
        public int ZoneID { get; set; }
    }
    public class SettingGetRegionModelOutput
    {
        [JsonProperty("ZoneID")]
        [DataMember]
        public int ZoneID { get; set; }

        [JsonProperty("RegionName")]
        [DataMember]
        public string RegionName { get; set; }

        [JsonProperty("RegionShortName")]
        [DataMember]
        public string RegionShortName { get; set; }
    }
}
