using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetHQModelInput : BaseClass
    {

    }
    public class SettingGetHQModelOutput
    {
        [JsonProperty("HQID")]
        [DataMember]
        public int HQID { get; set; }

        [JsonProperty("HQName")]
        [DataMember]
        public string HQName { get; set; }

        [JsonProperty("HQShortName")]
        [DataMember]
        public string HQShortName { get; set; }
    }
}
