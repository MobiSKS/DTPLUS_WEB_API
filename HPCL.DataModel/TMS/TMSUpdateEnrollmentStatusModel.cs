﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.TMS
{
    public class TMSUpdateEnrollmentStatusModelInput : BaseClass
    {
       
        public List<TMSInsertEnrollmentApprovalCustomerTrackingInput> TMSUpdateEnrollmentCustomerList { get; set; }
    }

    public class TMSInsertEnrollmentApprovalCustomerTrackingInput
    {
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
        [JsonPropertyName("TMSUserId")]
        [DataMember]
        public string TMSUserId { get; set; }
        [JsonPropertyName("TMSStatusID")]
        [DataMember]
        public string TMSStatusID { get; set; }
        [JsonPropertyName("Remarks")]
        [DataMember]
        public string Remarks { get; set; }
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }

    public class TMSUpdateEnrollmentStatusModelOutput:BaseClassOutput
    {
        [JsonProperty("Status")]
        [DataMember]
        public int Status { get; set; }

    }
}