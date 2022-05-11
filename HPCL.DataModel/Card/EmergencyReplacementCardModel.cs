using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{
    public class EmergencyReplacementCardModelInput 
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }

    }

    public class EmergencyReplacementCardModelOutput : BaseClassOutput
    {      
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

    }

    // for update 
    public class UpdateEmergencyReplacementCardsModelInput : BaseClass
    {       
        [JsonPropertyName("objEmergencyReplacementCards")]
        [DataMember]
        public List<objEmergencyReplacementCardsModelInput> objEmergencyReplacementCards { get; set; }

        [Required]
        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public string ModifiedBy { get; set; }
    }


    public class objEmergencyReplacementCardsModelInput
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }

        [Required]
        [JsonPropertyName("OldCardNo")]
        [DataMember]
        public string OldCardNo { get; set; }

        [Required]
        [JsonPropertyName("NewCardNo")]
        [DataMember]
        public string NewCardNo { get; set; }

    }

    public class EmergencyReplacementCardsModelOutput : BaseClassOutput
    {

    }



}
