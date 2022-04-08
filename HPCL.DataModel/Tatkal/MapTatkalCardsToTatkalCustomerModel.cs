using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Tatkal
{
    public class MapTatkalCardsToTatkalCustomerModelInput : BaseClass
    {
        [JsonPropertyName("RegionalId")]
        [DataMember]
        public string RegionalId { get; set; }

        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }
    }

    public class MapTatkalCardsToTatkalCustomerModelOutput
    {
        [JsonProperty("ObjGetStatusTatkalCardsToTatkalCustomer")]
        public List<GetStatusTatkalCardsToTatkalCustomerModelOutput> ObjGetStatusTatkalCardsToTatkalCustomer { get; set; }

        [JsonProperty("ObjGetCardDetailsTatkalCardsToTatkalCustomer")]
        public List<GetCardDetailsTatkalCardsToTatkalCustomerModelOutput> ObjGetCardDetailsTatkalCardsToTatkalCustomer { get; set; }
    }

    public class GetCardDetailsTatkalCardsToTatkalCustomerModelOutput
    {
        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }

    public class GetStatusTatkalCardsToTatkalCustomerModelOutput : BaseClassOutput
    {
    }
}
