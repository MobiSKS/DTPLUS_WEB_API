using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetCityModelInput : BaseClass
    {

    }
    public class SettingGetCityModelOutput
    {
        [JsonPropertyName("CityId")]
        [DataMember]
        public int CityId { get; set; }

        [JsonPropertyName("CityName")]
        [DataMember]
        public string CityName { get; set; }
    }
}
