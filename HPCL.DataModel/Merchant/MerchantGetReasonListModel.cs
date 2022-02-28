using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Merchant
{
     
    public class MerchantGetReasonListModelInput : BaseClass
    {

    }
    public class MerchantGetReasonListModelOutput
    {
        [JsonProperty("MerchantTypeCode")]
        [DataMember]
        public int MerchantTypeCode { get; set; }

        [JsonProperty("MerchantTypeName")]
        [DataMember]
        public string MerchantTypeName { get; set; }
    }
}
