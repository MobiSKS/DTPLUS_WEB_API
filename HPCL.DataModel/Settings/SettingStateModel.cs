using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetStateModelInput : BaseClass
    {
        [JsonPropertyName("CountryID")]
        [DataMember]
        public int CountryID { get; set; }
    }
    public class SettingGetStateModelOutput
    {
        [JsonProperty("CountryID")]
        [DataMember]
        public int CountryID { get; set; }

        [JsonProperty("StateID")]
        [DataMember]
        public int StateID { get; set; }

        [JsonProperty("StateName")]
        [DataMember]
        public string StateName { get; set; }
    }
}
