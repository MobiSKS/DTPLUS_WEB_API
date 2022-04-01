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
    public class ValidateMerchantErpCodeModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("ErpCode")]
        [DataMember]
        public string ErpCode { get; set; }
    }

    public class ValidateMerchantErpCodeModelOutput : BaseClassOutput
    {

    }
}
