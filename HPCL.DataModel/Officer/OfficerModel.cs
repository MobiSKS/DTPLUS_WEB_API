using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Officer
{
    public class OfficerInsertModelInput : BaseClass
    {
        [Required]
        [JsonProperty("FirstName")]
        [DataMember]
        public string FirstName { get; set; }

        //[Required]
        [JsonProperty("LastName")]
        [DataMember]
        public string LastName { get; set; }

        [Required]
        [JsonProperty("UserName")]
        [DataMember]
        //[StringLength(8, MinimumLength = 8)]
        public string UserName { get; set; }

        [Required]
        [JsonProperty("OfficerType")]
        [DataMember]
        public int OfficerType { get; set; }


        [Required]
        [JsonProperty("LocationId")]
        [DataMember]
        public int LocationId { get; set; }

        [Required]
        [JsonProperty("Address1")]
        [DataMember]
        public string Address1 { get; set; }

        [JsonProperty("Address2")]
        [DataMember]
        public string Address2 { get; set; }

        [JsonProperty("Address3")]
        [DataMember]
        public string Address3 { get; set; }

        [Required]
        [JsonProperty("StateId")]
        [DataMember]
        public int StateId { get; set; }

        //[Required]
        [JsonProperty("CityId")]
        [DataMember]
        public int CityId { get; set; }

        [Required]
        [JsonProperty("DistrictId")]
        [DataMember]
        public int DistrictId { get; set; }

        //[Required]
        [JsonProperty("Pin")]
        [DataMember]
        public string Pin { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        [JsonProperty("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }

        [JsonProperty("PhoneNo")]
        [DataMember]
        public string PhoneNo { get; set; }

        [Required]
        [JsonProperty("EmailId")]
        [DataMember]
        [RegularExpression("\\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\\Z", ErrorMessage = "Invalid Email Id")]
        public string EmailId { get; set; }


        [JsonProperty("Fax")]
        [DataMember]
        public string Fax { get; set; }

        [Required]
        [JsonProperty("Createdby")]
        [DataMember]
        public int Createdby { get; set; }

    }

    public class OfficerInsertModelOutput
    {

        [JsonProperty("Status")]
        [DataMember]
        public int Status { get; set; }

        [JsonProperty("Reason")]
        [DataMember]
        public string Reason { get; set; }

        [JsonProperty("ReferenceId")]
        [DataMember]
        public string ReferenceId { get; set; }

        [JsonProperty("Password")]
        [DataMember]
        public string Password { get; set; }

    }

    public class GetOfficerModelInput : BaseClass
    {
        [JsonProperty("OfficerType")]
        [DataMember]
        public int OfficerType { get; set; }

        [JsonProperty("Location")]
        [DataMember]
        public int Location { get; set; }
    }

    public class GetOfficerModelOutput
    {

        [JsonProperty("OfficerTypeID")]
        [DataMember]
        public int OfficerTypeID { get; set; }

        [JsonProperty("OfficerTypeName")]
        [DataMember]
        public string OfficerTypeName { get; set; }

        [JsonProperty("OfficerID")]
        [DataMember]
        public int OfficerID { get; set; }

        [JsonProperty("FirstName")]
        [DataMember]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        [DataMember]
        public string LastName { get; set; }

        [JsonProperty("UserName")]
        [DataMember]
        public string UserName { get; set; }

        [JsonProperty("Address1")]
        [DataMember]
        public string Address1 { get; set; }

        [JsonProperty("Address2")]
        [DataMember]
        public string Address2 { get; set; }

        [JsonProperty("Address3")]
        [DataMember]
        public string Address3 { get; set; }

        [JsonProperty("Pin")]
        [DataMember]
        public string Pin { get; set; }

        [JsonProperty("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }

        [JsonProperty("PhoneNo")]
        [DataMember]
        public string PhoneNo { get; set; }

        [JsonProperty("EmailId")]
        [DataMember]
        public string EmailId { get; set; }


        [JsonProperty("Fax")]
        [DataMember]
        public string Fax { get; set; }

        [JsonProperty("ReferenceId")]
        [DataMember]
        public string ReferenceId { get; set; }


        [JsonProperty("Createdby")]
        [DataMember]
        public int Createdby { get; set; }

        [JsonProperty("LocationId")]
        [DataMember]
        public int LocationId { get; set; }

       

        [JsonProperty("StateId")]
        [DataMember]
        public int StateId { get; set; }

        [JsonProperty("CityId")]
        [DataMember]
        public int CityId { get; set; }

        [JsonProperty("DistrictId")]
        [DataMember]
        public int DistrictId { get; set; }


        [JsonProperty("DistrictName")]
        [DataMember]
        public string DistrictName { get; set; }

        [JsonProperty("StateName")]
        [DataMember]
        public string StateName { get; set; }


        [JsonProperty("CityName")]
        [DataMember]
        public string CityName { get; set; }



    }

   
}
