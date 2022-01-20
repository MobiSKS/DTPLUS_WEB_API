using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetRoleModelInput : BaseClass
    {

    }
    public class SettingGetRoleModelOutput
    {
        [JsonProperty("RoleId")]
        [DataMember] 
        public int RoleId { get; set; }

        [JsonProperty("RoleName")]
        [DataMember]
        public string RoleName { get; set; }
    }
}
