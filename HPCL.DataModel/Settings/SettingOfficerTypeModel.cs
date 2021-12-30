using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetOfficerTypeModelInput : BaseClass
    {
    }
    public class SettingGetOfficerTypeModelOutput
    {
        [JsonProperty("OfficerTypeID")]
        [DataMember]
        public int OfficerTypeID { get; set; }

        [JsonProperty("OfficerTypeName")]
        [DataMember]
        public string OfficerTypeName { get; set; }

        [JsonProperty("OfficerTypeShortName")]
        [DataMember]
        public string OfficerTypeShortName { get; set; }
    }
}
