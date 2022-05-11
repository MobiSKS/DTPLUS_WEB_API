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
    public class UpdateConfigureSMSAlertsModelInput: BaseClass
    {
        [Required]
        [JsonPropertyName("TypeConfigureSMSAlerts")]
        [DataMember]
        public List<TypeConfigureSMSAlerts> TypeConfigureSMSAlerts { get; set; }
    }

    public class TypeConfigureSMSAlerts
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [Required]
        [JsonPropertyName("TransactionID")]
        [DataMember]
        public int TransactionID { get; set; }

        public int StatusId { get; set; }
      //  public string Designation { get; set; }
    }

    public class UpdateConfigureSMSAlertsModelOutput : BaseClassOutput
    {
        
    }
}
