using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{
    public class SettingGetEntityModelInput : BaseClass
    {

    }
    public class SettingGetEntityModelOutput
    {
        [JsonProperty("EntityId")]
        [DataMember]
        public int EntityId { get; set; }

        [JsonProperty("EntityName")]
        [DataMember]
        public string EntityName { get; set; }
    }
}
