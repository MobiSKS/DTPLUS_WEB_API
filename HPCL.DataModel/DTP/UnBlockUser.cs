using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.DTP
{
    public class GetDetailForUserUnblockByCustomerIdOrUserNameModelInput : BaseClass
    {    
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }
        
        [JsonPropertyName("UserName")]
        [DataMember]
        public string UserName { get; set; }

    }

    public class GetDetailForUserUnblockByCustomerIdOrUserNameModelOutput : BaseClassOutput
    {
        [Required]
        [JsonProperty("UserName")]
        [DataMember]
        //public string UserIdOrUserName { get; set; }
        public string UserName { get; set; }

        [Required]
        [JsonProperty("CreatedTime")]
        [DataMember]
        public string CreatedTime { get; set; }

    }
    
    public class UserUnBlockModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("UserName")]
        [DataMember]
        public string UserName { get; set; }

        [Required]
        [JsonPropertyName("BloackUnblockStatus")]
        [DataMember]
        public int BloackUnblockStatus { get; set; }
        
        [JsonPropertyName("Remark")]
        [DataMember]
        public string Remark { get; set; }       

        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }

    }

    public class UserUnBlockModelOutput : BaseClassOutput
    {


    }
}
