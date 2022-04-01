using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.RBE
{
    public class GetNewRbeAddCardsModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }
    }

    public class GetNewRbeAddCardsModelOutput
    {
        [JsonProperty("EnrollDate")]
        [DataMember]
        public string EnrollDate { get; set; }

        [JsonProperty("CustomerFormNumber")]
        [DataMember]
        public string CustomerFormNumber { get; set; }

        [JsonProperty("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }

        [JsonProperty("CustomerMobile")]
        [DataMember]
        public string CustomerMobile { get; set; }

        [JsonProperty("CustomerType")]
        [DataMember]
        public string CustomerType { get; set; }

        [JsonProperty("NoOfCards")]
        [DataMember]
        public string NoOfCards { get; set; }

        [JsonProperty("CustomerStatus")]
        [DataMember]
        public string CustomerStatus { get; set; }

        [JsonProperty("CardStatus")]
        [DataMember]
        public string CardStatus { get; set; }

        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }
}
