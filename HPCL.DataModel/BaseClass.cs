using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel
{
    public abstract class BaseClass
    {
        [Required]
        [JsonPropertyName("UserId")]
        [DataMember]
        public string Userid { get; set; }

        [Required]
        [JsonPropertyName("Useragent")]
        [DataMember]
        public string Useragent { get; set; }

        [Required]
        [JsonPropertyName("Userip")]
        [DataMember]
        public string Userip { get; set; }


        //[JsonPropertyName("ZonalId")]
        //[DataMember]
        //public string ZonalId { get; set; }


        //[JsonPropertyName("RegionalId")]
        //[DataMember]
        //public string RegionalId { get; set; }

    }

    public abstract class BaseClassOutput
    {
        [JsonProperty("Status")]
        [DataMember]
        public int Status { get; set; }

        [JsonProperty("Reason")]
        [DataMember]
        public string Reason { get; set; }
    }

    public abstract class CustomerAPIBaseClassInput
    {
        [Required]
        [JsonPropertyName("Username")]
        [DataMember]
        public string Username { get; set; }

        [Required]
        [JsonPropertyName("Password")]
        [DataMember]
        public string Password { get; set; }

        [JsonPropertyName("TransactionId")]
        [DataMember]
        public string TransactionId { get; set; }
    }

    public abstract class CustomerAPIBaseClassOutput
    {
        [JsonProperty("responseCode")]
        [DataMember]
        public string responseCode { get; set; }

        [JsonProperty("responseMessage")]
        [DataMember]
        public string responseMessage { get; set; }
    }

}
