using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Merchant
{
    public class GetMerchantOutletCategoryModelInput : BaseClass
    {

    }
    public class GetMerchantOutletCategoryModelOutput
    {
        [JsonProperty("OutletCategoryCode")]
        [DataMember]
        public int OutletCategoryCode { get; set; }

        [JsonProperty("OutletCategoryName")]
        [DataMember]
        public string OutletCategoryName { get; set; }
    }
}
