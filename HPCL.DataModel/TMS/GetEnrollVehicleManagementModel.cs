﻿using Newtonsoft.Json;
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
    public class GetEnrollVehicleManagementModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [Required]
        [JsonPropertyName("EnrollmentStatus")]
        [DataMember]
        public int EnrollmentStatus { get; set; }

        [JsonPropertyName("VehicleNo")]
        [DataMember]
        public string VehicleNo { get; set; }

        [JsonPropertyName("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }


    public class GetEnrollVehicleManagementModeloutput:BaseClassOutput
    {
        [JsonProperty("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }
        [JsonProperty("VehicleNo")]
        [DataMember]
        public string VehicleNo { get; set; }
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

        [JsonProperty("VehicleType")]
        [DataMember]
        public string VehicleType { get; set; }

    }


    public class GetEnrollVehicleManagementStatusInput:BaseClass
    {

    }


    public class GetEnrollVehicleManagementStatusOutput:BaseClassOutput
    {
        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }

        [JsonProperty("StatusId")]
        [DataMember]
        public string StatusId { get; set; }
    }

    public class InsertVehicleEnrollmentStatusInput : BaseClass
    {
       public List<InsertVehicleEnrollmentStatus> VehicleEnrollmentStatusList { get; set; }
    }
    public class InsertVehicleEnrollmentStatus
    {

        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [Required]
        [JsonPropertyName("VehicleNo")]
        [DataMember]
        public string VehicleNo { get; set; }

        [Required]
        [JsonPropertyName("VehicleType")]
        [DataMember]
        public string VehicleType { get; set; }

        [Required]
        [JsonPropertyName("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

        [Required]
        [JsonPropertyName("TMSUserId")]
        [DataMember]
        public string TMSUserId { get; set; }

        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }

    }

    public class InsertVehicleEnrollmentStatusOutput : BaseClassOutput
    {

    }

    
}

