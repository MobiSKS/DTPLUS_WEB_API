using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CustomerCardRequestEntryModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("RegionalId")]
        [DataMember]
        public Int32 RegionalId { get; set; }

        [Required]
        [JsonPropertyName("NoofCards")]
        [DataMember]
        public Int32 NoofCards { get; set; }

        [Required]
        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }
    public class CustomerCardRequestEntryModelOutput : BaseClassOutput
    {
        
    }

}
