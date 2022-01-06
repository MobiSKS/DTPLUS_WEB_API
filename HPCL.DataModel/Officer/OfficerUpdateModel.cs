using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HPCL.DataModel.Officer
{
    public class OfficerUpdateModelInput : BaseClass
    {
        [Required]
        [JsonProperty("FirstName")]
        [DataMember]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        [DataMember]
        public string LastName { get; set; }
         

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
        [JsonProperty("ModifiedBy")]
        [DataMember]
        public int ModifiedBy { get; set; }

        [Required]
        [JsonProperty("OfficerId")]
        [DataMember]
        public int OfficerId { get; set; }

    }

    public class OfficerUpdateModelOutput : BaseClassOutput
    {
        
    }
 
}
