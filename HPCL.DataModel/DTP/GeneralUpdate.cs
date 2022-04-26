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
    public class GetEntityOldFieldValueModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("EntityTypeId")]
        [DataMember]
        public int EntityFieldId { get; set; }
        [Required]
        [JsonPropertyName("EntityFieldId")]
        [DataMember]
        public int EntityTypeId { get; set; }
        [Required]
        [JsonPropertyName("CustomerIdOrCardOrMerchantId")]
        [DataMember]
        public string CustomerIdOrCardOrMerchantId { get; set; }

    }
    public class GetEntityOldFieldValueModelOutput : BaseClassOutput
    {

        [Required]
        [JsonPropertyName("OldValue")]
        [DataMember]
        public string OldValue { get; set; }

    }

    public class UpdateGeneralEntityFieldModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("EntityTypeId")]
        [DataMember]
        public int EntityTypeId { get; set; }

        [Required]
        [JsonPropertyName("EntityFieldId")]
        [DataMember]
        public int EntityFieldId { get; set; }
        [Required]
        [JsonPropertyName("CustomerIdOrCardOrMerchantId")]
        [DataMember]
        public string CustomerIdOrCardOrMerchantId { get; set; }
        [Required]
        [JsonPropertyName("NewValue")]
        [DataMember]
        public string NewValue { get; set; }

        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }

    }

    public class UpdateGeneralEntityFieldModelOutput : BaseClassOutput
    {


    }
}

