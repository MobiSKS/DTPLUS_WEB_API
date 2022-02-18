using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Officer
{
    public class OfficerKYCModelInput : BaseClass
    {


        [Required]
        [JsonPropertyName("RBEId")]
        [DataMember]
        public string RBEId { get; set; }

        [Required]
        [JsonPropertyName("IdProofType")]
        [DataMember]
        public int IdProofType { get; set; }


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
        public int AddressProofType { get; set; }


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
        [JsonPropertyName("RBESelfie")]
        [DataMember]
        public IFormFile RBESelfie { get; set; }

        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }


    }

    public class OfficerKYCModelOutput : BaseClassOutput
    {

    }


    public class GetRBEMobilenoModelInput : BaseClass
    {
        [JsonPropertyName("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }
    }

    public class GetRBEMobilenoModelOutput : BaseClassOutput
    {

    }

    public class GetOfficerCreationApprovalModelInput : BaseClass
    {
        [JsonPropertyName("FirstName")]
        [DataMember]
        public string FirstName { get; set; }

        [JsonPropertyName("UserName")]
        [DataMember]
        public string UserName { get; set; }

       
    }
   
    public class GetOfficerCreationApprovalModelOutput
    {
        [JsonProperty("FirstName")]
        [DataMember]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        [DataMember]
        public string LastName { get; set; }

        [JsonProperty("UserName")]
        [DataMember]
        public string UserName { get; set; }

        [JsonProperty("RBEId")]
        [DataMember]
        public string RBEId { get; set; }


        [JsonProperty("EmailId")]
        [DataMember]
        public string EmailId { get; set; }

        [JsonProperty("MakerComment")]
        [DataMember]
        public string MakerComment { get; set; }

        [JsonProperty("RequestOn")]
        [DataMember]
        public string RequestOn { get; set; }

        [JsonProperty("Requestedby")]
        [DataMember]
        public string Requestedby { get; set; }

        [JsonProperty("OfficerStatusId")]
        [DataMember]
        public string OfficerStatusId { get; set; }

        [JsonProperty("OfficerStatusName")]
        [DataMember]
        public string OfficerStatusName { get; set; }

    }


    public class GetRBEDetailbyUserNameModelInput : BaseClass
    {
        [JsonPropertyName("UserName")]
        [DataMember]
        public string UserName { get; set; }
    }

    public class GetRBEDetailbyUserNameModelOutput
    {
        [JsonProperty("Name")]
        [DataMember]
        public string Name { get; set; }

        [JsonProperty("RoleName")]
        [DataMember]
        public string RoleName { get; set; }

        [JsonProperty("Location")]
        [DataMember]
        public string Location { get; set; }

        [JsonProperty("IdProofTypeId")]
        [DataMember]
        public Int32 IdProofTypeId { get; set; }

        [JsonProperty("IdProofTypeName")]
        [DataMember]
        public string IdProofTypeName { get; set; }

        [JsonProperty("IdProofDocumentNo")]
        [DataMember]
        public string IdProofDocumentNo { get; set; }

        [JsonProperty("IdProofFront")]
        [DataMember]
        public string IdProofFront { get; set; }


        [JsonProperty("IdProofBack")]
        [DataMember]
        public string IdProofBack { get; set; }

        [JsonProperty("AddressProofTypeId")]
        [DataMember]
        public string AddressProofTypeId { get; set; }

        [JsonProperty("AddressProofTypeName")]
        [DataMember]
        public string AddressProofTypeName { get; set; }

        [JsonProperty("AddressProofDocumentNo")]
        [DataMember]
        public string AddressProofDocumentNo { get; set; }

        [JsonProperty("AddressProofFront")]
        [DataMember]
        public string AddressProofFront { get; set; }

        [JsonProperty("AddressProofBack")]
        [DataMember]
        public string AddressProofBack { get; set; }

        [JsonProperty("RBEPhoto")]
        [DataMember]
        public string RBEPhoto { get; set; }
    }
}
