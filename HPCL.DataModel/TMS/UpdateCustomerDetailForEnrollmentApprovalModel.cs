using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.TMS
{
    public class UpdateCustomerDetailForEnrollmentApprovalModelInput : BaseClass
    {
        public List<UpdateCustomerDetailForEnrollmentApproval> CustomerDetailForEnrollmentApproval { get; set; }
    }
    public class UpdateCustomerDetailForEnrollmentApproval
    { 

        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }


        [Required]
        [JsonPropertyName("TMSStatus")]
        [DataMember]
        public int TMSStatus { get; set; }

        [Required]
        [JsonPropertyName("Remarks")]
        [DataMember]
        public string Remarks { get; set; }

    }

    public class UpdateCustomerDetailForEnrollmentApprovalModelOutput : BaseClassOutput
    {

    }
}
