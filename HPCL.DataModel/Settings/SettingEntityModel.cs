using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{
    public class SettingGetEntityModelInput : BaseClass
    {

    }
    public class SettingGetEntityModelOutput
    {
        [JsonPropertyName("EntityId")]
        [DataMember]
        public int EntityId { get; set; }

        [JsonPropertyName("EntityName")]
        [DataMember]
        public string EntityName { get; set; }
    }
}
