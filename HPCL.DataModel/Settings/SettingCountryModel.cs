using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetCountryModelInput : BaseClass
    {

    }
    public class SettingGetCountryModelOutput
    {
        [JsonProperty("CountryID")]
        [DataMember]
        public int CountryID { get; set; }

        [JsonProperty("CountryName")]
        [DataMember]
        public string CountryName { get; set; }
    }
}
