using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.Merchant
{
    public class CheckMappedMerchantIDModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("MappedMerchantID")]
        [DataMember]
        public string MappedMerchantID { get; set; }
    }

    public class CheckMappedMerchantIDModelOutput : BaseClassOutput
    {

    }
}
