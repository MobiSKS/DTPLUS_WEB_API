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
    public class UpdateSmsAlertForMultipleMobileDetailModelinput:BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerDetailForSmsAlert")]
        [DataMember]
        public List<SmsAlertForMultipleMobile> CustomerDetailForSmsAlert { get; set; }
    }

    public class SmsAlertForMultipleMobile
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; } 

        [Required]
        [JsonPropertyName("MobileNo")]
        [DataMember]
        public string MobileNo { get; set; }

        public string Name { get; set; }
        public string Designation { get; set; }
    }

    public class UpdateSmsAlertForMultipleMobileDetailModelOutput:BaseClassOutput 
    {



    }
}
