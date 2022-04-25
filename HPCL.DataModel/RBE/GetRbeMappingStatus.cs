using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.RBE
{

    public class GetRbeMappingStatusModelInput : BaseClass
    {

    }
    public class GetRbeMappingStatusModelOutput
    {
        [JsonPropertyName("MappingStatus")]
        [DataMember]
        public string MappingStatus { get; set; }

    }
}
