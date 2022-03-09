using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HPCL.DataModel.Merchant
{
    public class MerchantGetTerminalTypeModelInput : BaseClass
    {

    }

    public class MerchantGetTerminalTypeModelOutput
    {
        [JsonProperty("Id")]
        [DataMember]
        public string Id { get; set; }

        [JsonProperty("TerminalIssuanceType")]
        [DataMember]
        public string TerminalIssuanceType { get; set; }

    }
}
