using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
    

    public class MerchantInsertTerminalDeInstallationRequestAuthorizationModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("Remark")]
        [DataMember]
        public string Remark { get; set; }

        [Required]
        [JsonPropertyName("Action")]
        [DataMember]
        public string Action { get; set; }

        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }

        [JsonPropertyName("ObjTerminalDeInstallationAuthorizationInput")]
        [DataMember]
        public List<MerchantTerminalDeInstallationAuthorizationInsertInput> ObjTerminalDeInstallationAuthorizationInput { get; set; }
    }

    public class MerchantTerminalDeInstallationAuthorizationInsertInput
    {
        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }


        [JsonPropertyName("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }

    }

    public class MerchantInsertTerminalDeInstallationRequestAuthorizationModelOutput : BaseClassOutput
    {
        [JsonProperty("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }


        [JsonProperty("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }
    }
}
