using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.Tatkal
{
    public class ValidateTatkalCustomerWithRegionModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }

        [Required]
        [JsonPropertyName("RegionalId")]
        [DataMember]
        public string RegionalId { get; set; }
    }

    public class ValidateTatkalCustomerWithRegionModelOutput : BaseClassOutput
    {

    }
}
