using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Officer
{

    public class GetOfficerTypeModelInput : BaseClass
    {
    }
    public class GetOfficerTypeModelOutput
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
