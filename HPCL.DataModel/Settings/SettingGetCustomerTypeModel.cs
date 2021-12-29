using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetCustomerTypeModelInput : BaseClass
    {

    }
    public class SettingGetCustomerTypeModelOutput
    {
        [JsonProperty("CustomerTypeId")]
        [DataMember]
        public int CustomerTypeId { get; set; }

        [JsonProperty("CustomerTypeName")]
        [DataMember]
        public string CustomerTypeName { get; set; }
    }
}
