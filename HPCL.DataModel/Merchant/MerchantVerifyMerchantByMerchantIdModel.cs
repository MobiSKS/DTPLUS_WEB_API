using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
    public class VerifyMerchantByMerchantIdModelInput : BaseClass
    { 
        [Required]
        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }
    }

    

    public class VerifyMerchantByMerchantIdModelOutput : BaseClassOutput
    {

    }


   
}
