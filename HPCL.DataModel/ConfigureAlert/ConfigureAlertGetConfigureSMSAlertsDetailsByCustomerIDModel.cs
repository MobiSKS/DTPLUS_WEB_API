using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.ConfigureAlert
{
    public class ConfigureAlertGetConfigureSMSAlertsDetailsByCustomerIDModelInput :BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }

    public class ConfigureAlertGetConfigureSMSAlertsDetailsByCustomerIDModelOutput : BaseClassOutput
    {
        
        [JsonProperty("TransactionType")]
        [DataMember]
        public string TransactionType { get; set; }


       
        [JsonProperty("TransactionID")]
        [DataMember]
        public int TransactionID { get; set; }

       
        [JsonProperty("SMSStatus")]
        [DataMember]
        public int SMSStatus { get; set; }

        
        [JsonProperty("SMSCondition")]
        [DataMember]
        public string SMSCondition { get; set; }
    }
}
