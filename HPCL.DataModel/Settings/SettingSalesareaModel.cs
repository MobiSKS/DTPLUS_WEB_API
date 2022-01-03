using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetSalesareaModelInput : BaseClass
    {
        [JsonProperty("RegionID")]
        [DataMember]
        public int RegionID { get; set; }
    }
    public class SettingGetSalesareaModelOutput
    {
        [JsonProperty("RegionID")]
        [DataMember]
        public int RegionID { get; set; }

        [JsonProperty("SalesAreaID")]
        [DataMember]
        public int SalesAreaID { get; set; }

        [JsonProperty("SalesAreaName")]
        [DataMember]
        public string SalesAreaName { get; set; }
    }
}
