using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetDistrictModelInput : BaseClass
    {
        [JsonPropertyName("StateID")]
        [DataMember]
        public int StateID { get; set; }
    }
    public class SettingGetDistrictModelOutput
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
    }
}
