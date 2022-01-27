using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.RegionalOffice
{
    public class GetRegionalOfficeModelInput : BaseClass
    {
        [JsonPropertyName("ZonalID")]
        [DataMember]
        public int ZonalID { get; set; }
    }
    public class GetRegionalOfficeModelOutput
    {
        [JsonProperty("RegionalOfficeID")]
        [DataMember]
        public int RegionalOfficeID { get; set; }

        [JsonProperty("RegionalOfficeName")]
        [DataMember]
        public string RegionalOfficeName { get; set; }
    }
}
