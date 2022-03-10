using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{
    public class MerchantCheckAvailityCardInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

        //[JsonPropertyName("RegionalId")]
        //[DataMember]
        //public Int32 RegionalId { get; set; }
    }

    public class MerchantCheckAvailityCardOutput  
    {
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }


    public class MerchantGetAvailityCardInput : BaseClass
    {
        [Required]
        [JsonPropertyName("RegionalOfficeId")]
        [DataMember]
        public Int32 RegionalOfficeId { get; set; }

        //[Required]
        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }
    }

    public class MerchantGetAvailityCardOutput
    {
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }


    public class MerchantGetAvailityALOTCCardCardInput : BaseClass
    {
       
        [Required]
        [JsonPropertyName("DealerCode")]
        [DataMember]
        public string DealerCode { get; set; }
    }

    public class MerchantGetAvailityALOTCCardCardOutput
    {
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }

}
