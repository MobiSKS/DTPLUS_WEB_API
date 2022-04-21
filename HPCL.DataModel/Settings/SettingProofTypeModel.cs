using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HPCL.DataModel.Settings
{
    public class SettingGetProofTypeModelInput : BaseClass
    {

    }
    public class SettingGetProofTypeModelOutput
    {
        [JsonProperty("ProofTypeId")]
        [DataMember]
        public int ProofTypeId { get; set; }


        [JsonProperty("ProofTypeName")]
        [DataMember]
        public string ProofTypeName { get; set; }
    }
}
