using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{
    public class SettingGetProofTypeModelInput : BaseClass
    {

    }
    public class SettingGetProofTypeModelOutput
    {
        [JsonPropertyName("ProofTypeId")]
        [DataMember]
        public int ProofTypeId { get; set; }


        [JsonPropertyName("ProofTypeName")]
        [DataMember]
        public string ProofTypeName { get; set; }
    }
}
