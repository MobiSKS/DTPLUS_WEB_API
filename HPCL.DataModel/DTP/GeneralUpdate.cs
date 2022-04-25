using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.DTP
{
   
    public class GetEntityFieldByEntityTypeIdModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("EntityTypeId")]
        [DataMember]
        public int EntityTypeId { get; set; }
       
    }

    public class GetEntityFieldByEntityTypeIdModelOutput : BaseClassOutput
    {
        [Required]
        [JsonPropertyName("EntityFieldId")]
        [DataMember]
        public string EntityFieldId { get; set; }

        [Required]
        [JsonPropertyName("EntityFieldName")]
        [DataMember]
        public string EntityFieldName { get; set; }

    }

    // 
}

