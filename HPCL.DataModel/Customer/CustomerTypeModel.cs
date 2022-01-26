using Newtonsoft.Json;
using System.Runtime.Serialization;
namespace HPCL.DataModel.Customer
{

    public class GetCustomerTypeModelInput : BaseClass
    {

    }
    public class GetCustomerTypeModelOutput
    {
        [JsonProperty("CustomerTypeId")]
        [DataMember]
        public int CustomerTypeId { get; set; }

        [JsonProperty("CustomerTypeName")]
        [DataMember]
        public string CustomerTypeName { get; set; }
    }
}
