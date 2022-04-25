using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.CustomerAPI
{
    public class CustomerAPICheckVechileNoModelInput : CustomerAPIBaseClassInput
    {
        [Required]
        [JsonPropertyName("VehicleRegistrationNumber")]
        [DataMember]
        public string VehicleRegistrationNumber { get; set; }
    }

    public class CustomerAPICheckVechileNoModelOutput : CustomerAPIBaseClassOutput
    {

    }
}
