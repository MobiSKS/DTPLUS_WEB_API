using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{

    public class CustomerCheckPancardModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("IncomeTaxPan")]
        [DataMember]
        public string IncomeTaxPan { get; set; }
    }
    public class CustomerCheckPancardModelOutput : BaseClassOutput
    {

    }

    public class CustomerCheckPancardbyDistrictIdModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("IncomeTaxPan")]
        [DataMember]
        public string IncomeTaxPan { get; set; }

        [Required]
        [JsonPropertyName("DistrictId")]
        [DataMember]
        public string DistrictId { get; set; }
    }
    public class CustomerCheckPancardbyDistrictIdModelOutput : BaseClassOutput
    {

    }

    public class CheckPancardbyDistrictIdAndCustomerReferenceNoModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("IncomeTaxPan")]
        [DataMember]
        public string IncomeTaxPan { get; set; }

        [Required]
        [JsonPropertyName("DistrictId")]
        [DataMember]
        public int DistrictId { get; set; }

        [Required]
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }
    }
    public class CheckPancardbyDistrictIdAndCustomerReferenceNoModelOutput : BaseClassOutput
    {

    }
}
