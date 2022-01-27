using Newtonsoft.Json;
using System.Runtime.Serialization;


namespace HPCL.DataModel.ZonalOffice
{
    public class GetZonalOfficeModelInput : BaseClass
    {
       
    }
    public class GetZonalOfficeModelOutput
    {
        [JsonProperty("ZonalOfficeID")]
        [DataMember]
        public int ZonalOfficeID { get; set; }

        [JsonProperty("ZonalOfficeName")]
        [DataMember]
        public string ZonalOfficeName { get; set; }
    }
}
