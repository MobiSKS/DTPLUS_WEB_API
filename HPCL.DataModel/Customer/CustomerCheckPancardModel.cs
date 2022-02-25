using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{

    public class CustomerCheckPancardModelInput : BaseClass
    {
        [JsonPropertyName("IncomeTaxPan")]
        [DataMember]
        public string IncomeTaxPan { get; set; }
    }
    public class CustomerCheckPancardModelOutput : BaseClassOutput
    {

    }
}
