﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Merchant
{

    public class MerchantViewCardMerchantAllocationModelInput : BaseClass
    {
        [Required]
        [JsonPropertyName("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }

        [JsonPropertyName("CardNo")]
        [DataMember]
        public string CardNo { get; set; }
    }

    
    public class MerchantTotalCardModelOutput
    {
        [JsonProperty("TotalAllocatedCards")]
        [DataMember]
        public Int32 TotalAllocatedCards { get; set; }

        [JsonProperty("TotalMappedCards")]
        [DataMember]
        public Int32 TotalMappedCards { get; set; }


        [JsonProperty("TotalUnmappedCards")]
        [DataMember]
        public Int32 TotalUnmappedCards { get; set; }
    }

    public class MerchantViewCardMerchantDetailModelOutput
    {
        [JsonProperty("ZonalOfficeName")]
        [DataMember]
        public string ZonalOfficeName { get; set; }

        [JsonProperty("RegionalOfficeName")]
        [DataMember]
        public string RegionalOfficeName { get; set; }

        [JsonProperty("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }


        [JsonProperty("CustomerName")]
        [DataMember]
        public string CustomerName { get; set; }

        [JsonProperty("CardNo")]
        [DataMember]
        public string CardNo { get; set; }

        [JsonProperty("MerchantId")]
        [DataMember]
        public string MerchantId { get; set; }

        [JsonProperty("AllocationDate")]
        [DataMember]
        public string AllocationDate { get; set; }

        [JsonProperty("MappingDate")]
        [DataMember]
        public string MappingDate { get; set; }

        [JsonProperty("Status")]
        [DataMember]
        public string Status { get; set; }


        [JsonProperty("RetailOutletName")]
        [DataMember]
        public string RetailOutletName { get; set; }

        
    }

    public class MerchantViewCardMerchantAllocationModelOutput
    {
        [JsonProperty("ObjMerchantTotalCardDetail")]
        public List<MerchantTotalCardModelOutput> ObjMerchantTotalCardDetail { get; set; }

        [JsonProperty("ObjMerchantViewCardDetail")]
        public List<MerchantViewCardMerchantDetailModelOutput> ObjMerchantViewCardDetail { get; set; }

    }
}