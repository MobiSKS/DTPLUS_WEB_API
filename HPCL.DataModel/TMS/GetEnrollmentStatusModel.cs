
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.TMS
{
    public class GetEnrollmentStatusModelInput : BaseClass
    {

    }
    public class GetEnrollmentStatusModelOutput
    {
        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }

        [JsonProperty("StatusId")]
        [DataMember]
        public string StatusId { get; set; }
    }

   
}
