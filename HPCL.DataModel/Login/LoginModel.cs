using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Login
{
  

    public class GetLoginModelInput : BaseClass
    {

        [JsonPropertyName("Password")]
        [DataMember]
        public string Password { get; set; }
 
    }

    public class GetLoginModelOutput : BaseClassOutput
    {
        [JsonProperty("LoginType")]
        [DataMember]
        public string LoginType { get; set; }


        [JsonProperty("UserId")]
        [DataMember]
        public string UserId { get; set; }

        [JsonProperty("UserName")]
        [DataMember]
        public string UserName { get; set; }

        [JsonProperty("EmailId")]
        [DataMember]
        public string EmailId { get; set; }

        [JsonProperty("UserRole")]
        [DataMember]
        public string UserRole { get; set; }


        [JsonProperty("FirstName")]
        [DataMember]
        public string FirstName { get; set; }

        [JsonProperty("LastName")]
        [DataMember]
        public string LastName { get; set; }


        [JsonProperty("StatusId")]
        [DataMember]
        public int StatusId { get; set; }

        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }


        [JsonProperty("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }


        [JsonProperty("RegionalOfficeID")]
        [DataMember]
        public string RegionalOfficeID { get; set; }


        [JsonProperty("RegionalOfficeName")]
        [DataMember]
        public string RegionalOfficeName { get; set; }

        [JsonProperty("ZonalOfficeID")]
        [DataMember]
        public string ZonalOfficeID { get; set; }


        [JsonProperty("ZonalOfficeName")]
        [DataMember]
        public string ZonalOfficeName { get; set; }

    }
}
