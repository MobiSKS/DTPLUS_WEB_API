using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetCityModelInput : BaseClass
    {

    }
    public class SettingGetCityModelOutput
    {
        [JsonProperty("CityId")]
        [DataMember]
        public int CityId { get; set; }

        [JsonProperty("CityName")]
        [DataMember]
        public string CityName { get; set; }
    }
}
