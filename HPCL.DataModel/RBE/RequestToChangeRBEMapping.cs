using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.RBE
{
    public class RequestToChangeRBEMappingModelInput : BaseClass
    {
        [JsonPropertyName("NewRBEUserName")]
        [DataMember]
        public string NewRBEUserName { get; set; }
    }

    public class RequestToChangeRBEMappingModelOutput : BaseClassOutput
    {

        [JsonProperty("OTP")]
        [DataMember]
        public string OTP { get; set; }
    }

}
