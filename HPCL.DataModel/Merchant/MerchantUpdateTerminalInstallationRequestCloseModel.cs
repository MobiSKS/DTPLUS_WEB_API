using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
    public class MerchantUpdateTerminalInstallationRequestCloseModelInput : BaseClass
    {

        [JsonPropertyName("StatusId")]
        [DataMember]
        public Int32 StatusId { get; set; }

        [JsonPropertyName("ReasonId")]
        [DataMember]
        public Int32 ReasonId { get; set; }

        [JsonPropertyName("ObjMerchantTerminalInstallationRequestCloseDetail")]
        [DataMember]
        public List<MerchantTerminalInstallationRequestCloseModelInput> ObjMerchantTerminalInstallationRequestCloseDetail { get; set; }
    }

    public class MerchantTerminalInstallationRequestCloseModelInput
    {

        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }

        [JsonPropertyName("TerminalId")]
        [DataMember]
        public string TerminalId { get; set; }
    }

    public class MerchantUpdateTerminalInstallationRequestCloseModelOutput : BaseClassOutput
    {

    }
}
