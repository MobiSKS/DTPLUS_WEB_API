using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace HPCL.DataModel.Settings
{

    public class SettingGetStoreCategoriesModelInput : BaseClass
    {

    }
    public class SettingGetStoreCategoriesModelOutput
    {
        [JsonProperty("StoreCategoryCode")]
        [DataMember]
        public int StoreCategoryCode { get; set; }

        [JsonProperty("StoreCategoryName")]
        [DataMember]
        public string StoreCategoryName { get; set; }
    }
}
