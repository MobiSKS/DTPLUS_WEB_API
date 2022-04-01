using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.RBE
{
    public class GetRbeDashboardModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }
    }

    public class GetRbeDashboardModelOutput
    {
        [JsonProperty("NewEnrollmentCount")]
        [DataMember]
        public Int32 NewEnrollmentCount { get; set; }

        [JsonProperty("NewCardCount")]
        [DataMember]
        public Int32 NewCardCount { get; set; }

        [JsonProperty("PendingVisitCount")]
        [DataMember]
        public Int32 PendingVisitCount { get; set; }

        [JsonProperty("CompletedVisitCount")]
        [DataMember]
        public Int32 CompletedVisitCount { get; set; }
    }
}
