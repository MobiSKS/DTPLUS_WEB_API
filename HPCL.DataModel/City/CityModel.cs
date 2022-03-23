using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.City
{

    public class GetCityModelInput : BaseClass
    {

    }
    public class GetCityModelOutput
    {
        [JsonPropertyName("StateId")]
        [DataMember]
        public int StateId { get; set; }

        [JsonPropertyName("CityId")]
        [DataMember]
        public int CityId { get; set; }

        [JsonPropertyName("CityCode")]
        [DataMember]
        public string CityCode { get; set; }

        [JsonPropertyName("CityName")]
        [DataMember]
        public string CityName { get; set; }


        [JsonPropertyName("CityShortName")]
        [DataMember]
        public string CityShortName { get; set; }
    }

    public class DeleteCityModelInput : BaseClass
    {
        [JsonPropertyName("CityID")]
        [DataMember]
        public int CityID { get; set; }

        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }


    }

    public class DeleteCityModelOutput : BaseClassOutput
    {

    }
}
