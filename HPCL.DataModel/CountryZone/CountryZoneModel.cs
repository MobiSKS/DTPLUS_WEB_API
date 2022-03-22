using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.CountryZone
{
    public class GetCountryZoneModelInput : BaseClass
    {
        [JsonPropertyName("HQID")]
        [DataMember]
        public int HQID { get; set; }
    }
    public class GetCountryZoneModelOutput
    {
        [JsonProperty("HQID")]
        [DataMember]
        public int HQID { get; set; }

        [JsonProperty("ZoneID")]
        [DataMember]
        public int ZoneID { get; set; }

        [JsonProperty("ZoneName")]
        [DataMember]
        public string ZoneName { get; set; }

        [JsonProperty("ZoneShortName")]
        [DataMember]
        public string ZoneShortName { get; set; }
    }
}
