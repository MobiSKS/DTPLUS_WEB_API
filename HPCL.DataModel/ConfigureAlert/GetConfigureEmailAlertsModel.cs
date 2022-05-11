using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.ConfigureAlert
{
    public class GetConfigureEmailAlertsModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }
    }
    public class GetConfigureEmailAlertsOutput : BaseClassOutput
    {
        [JsonProperty("ServieId")]
        [DataMember]
        public int ServieId { get; set; }
        [JsonProperty("ServiceName")]
        [DataMember]
        public string ServiceName { get; set; }

        [JsonProperty("ServiceStatus")]
        [DataMember]
        public int ServiceStatus { get; set; }

    }
}
