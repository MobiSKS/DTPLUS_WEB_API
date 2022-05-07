﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.AshokLeyland
{
    public class UpdateALCustomerDetailModelinput : BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerID")]
        [DataMember]
        public string CustomerID { get; set; }

        [Required]
        [JsonPropertyName("IndividualOrgNameTitle")]
        [DataMember]
        public string IndividualOrgNameTitle { get; set; }

        [Required]
        [JsonPropertyName("IndividualOrgName")]
        [DataMember]
        public string IndividualOrgName { get; set; }

        [Required]
        [JsonPropertyName("NameOnCard")]
        [DataMember]
        public string NameOnCard { get; set; }

        [Required]
        [JsonPropertyName("CommunicationCityName")]
        [DataMember]
        public string CommunicationCityName { get; set; }

        [Required]
        [JsonPropertyName("CommunicationStateId")]
        [DataMember]
        public int CommunicationStateId { get; set; }

        [Required]
        [JsonPropertyName("CommunicationPhoneNo")]
        [DataMember]
        public string CommunicationPhoneNo { get; set; }

        [Required]
        [JsonPropertyName("CommunicationMobileNo")]
        [DataMember]
        public string CommunicationMobileNo { get; set; }

        [Required]
        [JsonPropertyName("CommunicationAddress1")]
        public string CommunicationAddress1 { get; set; }

        [DataMember]
        [Required]
        [JsonPropertyName("CommunicationAddress2")]
        public string CommunicationAddress2 { get; set; }

        [DataMember]
        [Required]
        [JsonPropertyName("CommunicationPincode")]
        public string CommunicationPincode { get; set; }

        [Required]
        [JsonPropertyName("CommunicationDistrictId")]
        [DataMember]
        public int CommunicationDistrictId { get; set; }

        [DataMember]
        [Required]
        [JsonPropertyName("CommunicationFax")]
        public string CommunicationFax { get; set; }

        [DataMember]
        [Required]
        [JsonPropertyName("CommunicationEmailid")]
        public string CommunicationEmailid { get; set; }

        
    }

    public class UpdateALCustomerDetailModelOutput : BaseClassOutput
    {
    }
}
