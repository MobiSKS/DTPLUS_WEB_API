using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
namespace HPCL.DataModel.Merchant
{
   
    public class MerchantInsertTerminalDeInstallationRequestApprovalModelInput : BaseClass
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

        [JsonPropertyName("ObjTerminalDeInstallationInsertInput")]
        [DataMember]
        public List<MerchantTerminalDeInstallationInsertInput> ObjTerminalDeInstallationInsertInput { get; set; }
    }

    public class MerchantTerminalDeInstallationInsertInput
    {
        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }


        [JsonPropertyName("TerminalID")]
        [DataMember]
        public string TerminalID { get; set; }

    }

    public class MerchantInsertTerminalDeInstallationRequestApprovalModelOutput : BaseClassOutput
    {
        [JsonProperty("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }


        [JsonProperty("TerminalID")]
        [DataMember]
        public string TerminalID { get; set; }
    }
}
