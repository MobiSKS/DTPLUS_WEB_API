using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.AshokLeyland
{
    public class GetAlCustomerDetailForVerificationModelInput:BaseClass
    {
        [Required]
        [JsonPropertyName("StateID")]
        [DataMember]
        public int StateID { get; set; }
        [Required]
        [JsonPropertyName("FormNumber")]
        [DataMember]
        public string FormNumber { get; set; }
        [Required]
        [JsonPropertyName("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }

        [Required]
        [JsonPropertyName("Status")]
        [DataMember]
        public int Status { get; set; }
    }

    public class GetAlCustomerDetailForVerificationModelOutput : BaseClassOutput
    {
        [JsonProperty("FormNumber")]
        [DataMember]
        public int FormNumber { get; set; }
        [JsonProperty("CustomerID")]
        [DataMember]
        public int CustomerID { get; set; }
        [JsonProperty("CustomerName")]
        [DataMember]
        public int CustomerName { get; set; }
        [JsonProperty("CustomerAddress")]
        [DataMember]
        public int CustomerAddress { get; set; }
        [JsonProperty("PhoneNo")]
        [DataMember]
        public int PhoneNo { get; set; }
        [JsonProperty("MobileNo")]
        [DataMember]
        public int MobileNo { get; set; }
       
    }
}
