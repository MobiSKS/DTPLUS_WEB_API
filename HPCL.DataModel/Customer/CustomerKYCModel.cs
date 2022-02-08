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
        [JsonPropertyName("CustomerReferenceNo")]
        [DataMember]
        public Int64 CustomerReferenceNo { get; set; }

        [Required]
        [JsonPropertyName("IdProofType")]
        [DataMember]
        public string IdProofType { get; set; }


        [Required]
        [JsonPropertyName("IdProofDocumentNo")]
        [DataMember]
        public string IdProofDocumentNo { get; set; }


        [Required]
        [JsonPropertyName("IdProofFront")]
        [DataMember]
        public IFormFile IdProofFront { get; set; }

        [Required]
        [JsonPropertyName("IdProofBack")]
        [DataMember]
        public IFormFile IdProofBack { get; set; }


        [Required]
        [JsonPropertyName("AddressProofType")]
        [DataMember]
        public string AddressProofType { get; set; }


        [Required]
        [JsonPropertyName("AddressProofDocumentNo")]
        [DataMember]
        public string AddressProofDocumentNo { get; set; }


        [Required]
        [JsonPropertyName("AddressProofFront")]
        [DataMember]
        public IFormFile AddressProofFront { get; set; }

        [Required]
        [JsonPropertyName("AddressProofBack")]
        [DataMember]
        public IFormFile AddressProofBack { get; set; }


        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }

    public class CustomerKYCModelOutput : BaseClassOutput
    {

    }
}
