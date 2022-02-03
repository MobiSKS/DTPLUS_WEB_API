using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CustomerGetVehicleTypeModelInput : BaseClass
    {

    }

    public class CustomerGetVehicleTypeModelOutput
    {
        [JsonProperty("VehicleTypeId")]
        [DataMember]
        public Int32 VehicleTypeId { get; set; }

        [JsonProperty("VehicleTypeName")]
        [DataMember]
        public string VehicleTypeName { get; set; }
    }
}
