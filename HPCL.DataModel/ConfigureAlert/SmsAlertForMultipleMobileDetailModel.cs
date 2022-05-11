using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.ConfigureAlert
{
    public class GetSmsAlertForMultipleMobileDetailModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }

    public class GetSmsAlertForMultipleMobileDetailModelOutput : BaseClass

    {
        [JsonProperty("CustomerMultipleMobileDetail")]
        [DataMember]
        public List<SmsAlertForMultipleMobileDetail> CustomerMultipleMobileDetail { get; set; }

        [JsonProperty("CustomerDetail")]
        [DataMember]
        public List<CustomerDetail> CustomerDetail { get; set; }
    }




    public class SmsAlertForMultipleMobileDetail
    {
        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
        [JsonProperty("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }
        [JsonProperty("Name")]
        [DataMember]
        public string Name { get; set; }

        [JsonProperty("Designation")]
        [DataMember]
        public string Designation { get; set; }

        [JsonProperty("StatusFlag")]
        [DataMember]
        public string StatusFlag { get; set; }
    }

    public class CustomerDetail
    {
        [JsonProperty("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }

        [JsonProperty("NameOnCard")]
        [DataMember]
        public string NameOnCard { get; set; }

        [JsonProperty("CommunicationMobileNo")]
        [DataMember]
        public string CommunicationMobileNo { get; set; }

        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }
}

