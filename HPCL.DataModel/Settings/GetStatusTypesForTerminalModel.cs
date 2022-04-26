using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HPCL.DataModel.Settings
{
    public class GetStatusTypesForTerminalModelInput : BaseClass
    {
    }

    public class GetStatusTypesForTerminalModelOutput
    {
        [JsonProperty("EntityTypeId")]
        [DataMember]
        public int EntityTypeId { get; set; }


        [JsonProperty("StatusId")]
        [DataMember]
        public int StatusId { get; set; }


        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }


        [JsonProperty("StatusCode")]
        [DataMember]
        public string StatusCode { get; set; }


        [JsonProperty("StatusDescription")]
        [DataMember]
        public string StatusDescription { get; set; }
    }
}
