using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.DTP
{
    public  class GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
    }

    public class GetBlockUnBlockCustomerCCMSAccountByCustomerIdModelOutput : BaseClassOutput
    {
        [JsonProperty("IndividualOrgName")]
        [DataMember]
        public string IndividualOrgName { get; set; }

        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }

        [JsonProperty("CCMSBalanceStatusId")]
        [DataMember]
        public int CCMSBalanceStatusId { get; set; }

        [JsonProperty("CCMSBalanceRemarks")]
        [DataMember]
        public string CCMSBalanceRemarks { get; set; }
    }
}
