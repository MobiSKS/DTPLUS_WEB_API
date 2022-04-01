using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class GetNameandFormNumberbyCustomerIdModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }
    }
    public class GetNameandFormNumberbyCustomerIdModelOutput
    {
        [JsonProperty("GetNameandFormNumberbyCustomerId")]
        public List<GetNameandFormNumberModelOutput> GetNameandFormNumberOutput { get; set; }

        [JsonProperty("GetStatus")]
        public List<GetStatusModelOutput> GetStatusOutput { get; set; }
    }

    public class GetNameandFormNumberModelOutput
    {
        [JsonProperty("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }
    }

    public class GetStatusModelOutput : BaseClassOutput
    {
        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }

}
