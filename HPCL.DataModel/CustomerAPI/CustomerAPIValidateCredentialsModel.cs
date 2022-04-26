using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HPCL.DataModel.CustomerAPI
{
    public class CustomerAPIValidateCredentialsModelInput : CustomerAPIBaseClassInput
    {
    }

    public class CustomerAPIValidateCredentialsModelOutput : CustomerAPIBaseClassOutput
    {
        [JsonProperty("userType")]
        [DataMember]
        public string userType { get; set; }
    }
}
