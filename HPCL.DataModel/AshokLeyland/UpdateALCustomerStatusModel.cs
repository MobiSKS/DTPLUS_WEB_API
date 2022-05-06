using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HPCL.DataModel.AshokLeyland
{
    public class UpdateALCustomerStatusModelInput:BaseClass
    {
        [Required]
        [JsonProperty("CustomerID")]
        [DataMember]
        public int CustomerID { get; set; }

        [Required]
        [JsonProperty("CustomerStatus")]
        [DataMember]
        public int CustomerStatus { get; set; }
       
        
        
    }

    public class UpdateALCustomerStatusModelOutput : BaseClassOutput
    {
    }
}
