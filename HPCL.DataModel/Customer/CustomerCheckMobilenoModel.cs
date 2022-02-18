using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CheckMobileNumberModelInput : BaseClass
    {
        [JsonPropertyName("CommunicationMobileNo")]
        [DataMember]
        public string CommunicationMobileNo { get; set; }
    }
    public class CheckMobileNumberModelOutput : BaseClassOutput
    {

    }
}
