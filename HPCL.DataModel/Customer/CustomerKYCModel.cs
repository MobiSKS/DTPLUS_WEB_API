using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CustomerKYCModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("FormNumber")]
        [DataMember]
        public Int64 FormNumber { get; set; }

        [Required]
        [JsonPropertyName("FileName")]
        [DataMember]
        public string FileName { get; set; }

        [Required]
        [JsonPropertyName("ImageFileName")]
        [DataMember]
        //public string FileNamePath { get; set; }
        public IFormFile ImageFileName { get; set; }

        [Required]
        [JsonPropertyName("KYCType")]
        [DataMember]
        public string KYCType { get; set; }

        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }

    public class CustomerKYCModelOutput : BaseClassOutput
    {

    }
}
