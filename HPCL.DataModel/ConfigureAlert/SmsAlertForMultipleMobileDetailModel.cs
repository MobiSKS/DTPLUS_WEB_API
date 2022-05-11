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
        public string CustomerID { get; set; }
        public string MobileNo { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string StatusFlag { get; set; }
    }

    public class CustomerDetail
    {
        public string CustomerName { get; set; }
        public string NameOnCard { get; set; }
        public string CommunicationMobileNo { get; set; }
        public string CustomerID { get; set; }
    }
}

