
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.TMS
{
    public class GetEnrollmentStatusModelInput : BaseClass
    {

    }
    public class GetEnrollmentStatusModelOutput
    {
        [JsonPropertyName("StatusName")]
        [DataMember]
        public string StatusName { get; set; }      
    }
}
