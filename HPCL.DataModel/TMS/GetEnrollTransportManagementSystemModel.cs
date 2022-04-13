using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.TMS
{
    public class GetEnrollTransportManagementSystemModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }
    }
    public class GetEnrollTransportManagementSystemModelOutput : BaseClassOutput
    {

    }
}
