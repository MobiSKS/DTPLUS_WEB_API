using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetCustomerSubTypeModelInput : BaseClass
    {
        [JsonProperty("CustomerTypeId")]
        [DataMember]
        public int CustomerTypeId { get; set; }
    }
    public class SettingGetCustomerSubTypeModelOutput
    {
        [JsonProperty("CustomerSubtypeId")]
        [DataMember]
        public int CustomerSubtypeId { get; set; }

        [JsonProperty("CustomerSubtypeName")]
        [DataMember]
        public string CustomerSubtypeName { get; set; }
    }
}
