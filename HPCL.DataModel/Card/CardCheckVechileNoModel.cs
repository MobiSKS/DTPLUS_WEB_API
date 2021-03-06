using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{

    public class CardCheckVechileNoModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("VechileNo")]
        [DataMember]
        public string VechileNo { get; set; }
    }
    public class CardCheckVechileNoModelOutput : BaseClassOutput
    {

    }

    
}
