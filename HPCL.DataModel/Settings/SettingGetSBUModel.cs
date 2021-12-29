using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetSBUModelInput : BaseClass
    {

    }
    public class SettingGetSBUModelOutput
    {
        [JsonProperty("SBUId")]
        [DataMember]
        public int SBUId { get; set; }

        [JsonProperty("SBUName")]
        [DataMember]
        public string SBUName { get; set; }
    }
}
