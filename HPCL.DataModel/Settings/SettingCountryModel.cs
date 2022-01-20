using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetCountryModelInput : BaseClass
    {

    }
    public class SettingGetCountryModelOutput
    {
        [JsonPropertyName("CountryID")]
        [DataMember]
        public int CountryID { get; set; }

        [JsonPropertyName("CountryName")]
        [DataMember]
        public string CountryName { get; set; }
    }
}
