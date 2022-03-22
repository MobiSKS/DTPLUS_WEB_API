using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Country
{

    public class GetCountryModelInput : BaseClass
    {

    }
    public class GetCountryModelOutput
    {
        [JsonPropertyName("CountryID")]
        [DataMember]
        public int CountryID { get; set; }

        [JsonPropertyName("CountryName")]
        [DataMember]
        public string CountryName { get; set; }

        [JsonPropertyName("CountryShortName")]
        [DataMember]
        public string CountryShortName { get; set; }
    }
}
