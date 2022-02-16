﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Officer
{
    

    public class GetOfficerModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("OfficerType")]
        [DataMember]
        public int OfficerType { get; set; }

        [JsonPropertyName("Location")]
        [DataMember]
        public int Location { get; set; }
    }

    public class BindOfficerModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("OfficerID")]
        [DataMember]
        public int OfficerID { get; set; }
 
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
        public string Createdby { get; set; }

        //[JsonProperty("LocationId")]
        //[DataMember]
        //public int LocationId { get; set; }
       

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


        [JsonProperty("Location")]
        [DataMember]
        public string Location { get; set; }

    }

    public class GetOfficerLocationMappingModelOutput
    {

        [JsonProperty("OfficerId")]
        [DataMember]
        public int OfficerId { get; set; }

        [JsonProperty("ZOId")]
        [DataMember]
        public int ZOId { get; set; }

        [JsonProperty("ZOName")]
        [DataMember]
        public string ZOName { get; set; }


        [JsonProperty("ROId")]
        [DataMember]
        public int ROId { get; set; }

        [JsonProperty("ROName")]
        [DataMember]
        public string ROName { get; set; }

    }


    public class BindRBEOfficerModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("RBEId")]
        [DataMember]
        public string RBEId { get; set; }

    }

    public class BindRBEOfficerModelOutput
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

        [JsonProperty("RBEId")]
        [DataMember]
        public string RBEId { get; set; }

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
        public string Createdby { get; set; }

        //[JsonProperty("LocationId")]
        //[DataMember]
        //public int LocationId { get; set; }


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

        [JsonProperty("RegionalOfficeId")]
        [DataMember]
        public int RegionalOfficeId { get; set; }

        [JsonProperty("RegionalOfficeName")]
        [DataMember]
        public string RegionalOfficeName { get; set; }

        [JsonProperty("ZonalOfficeId")]
        [DataMember]
        public int ZonalOfficeId { get; set; }

        [JsonProperty("ZonalOfficeName")]
        [DataMember]
        public string ZonalOfficeName { get; set; }


    }
}
