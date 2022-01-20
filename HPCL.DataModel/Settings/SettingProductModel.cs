using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetProductModelInput : BaseClass
    {

    }
    public class SettingGetProductModelOutput
    {
        [JsonProperty("ProductID")]
        [DataMember]
        public int ProductID { get; set; }

        [JsonProperty("ProductName")]
        [DataMember]
        public string ProductName { get; set; }
    }
}
