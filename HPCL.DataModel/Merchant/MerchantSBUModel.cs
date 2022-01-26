using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{

    public class MerchantGetSBUModelInput : BaseClass
    {

    }
    public class MerchantGetSBUModelOutput
    {
        [JsonProperty("SBUId")]
        [DataMember]
        public int SBUId { get; set; }

        [JsonProperty("SBUName")]
        [DataMember]
        public string SBUName { get; set; }
    }
}
