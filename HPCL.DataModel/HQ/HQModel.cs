﻿using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.HQ
{

    public class GetHQModelInput : BaseClass
    {

    }
    public class GetHQModelOutput
    {
        [JsonProperty("HQID")]
        [DataMember]
        public int HQID { get; set; }

        [JsonProperty("HQCode")]
        [DataMember]
        public string HQCode { get; set; }

        [JsonProperty("HQName")]
        [DataMember]
        public string HQName { get; set; }

        [JsonProperty("HQShortName")]
        [DataMember]
        public string HQShortName { get; set; }
    }

    public class InsertHQModelInput
    {
        [JsonPropertyName("HQCode")]
        [DataMember]
        public string HQCode { get; set; }

        [JsonPropertyName("HQName")]
        [DataMember]
        public string HQName { get; set; }

        [JsonPropertyName("HQShortName")]
        [DataMember]
        public string HQShortName { get; set; }

        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public int CreatedBy { get; set; }
    }

    public class InsertHQModelOutput : BaseClassOutput
    {

    }

    public class UpdateHQModelInput
    {
        [JsonPropertyName("HQID")]
        [DataMember]
        public int HQID { get; set; }

        [JsonPropertyName("HQCode")]
        [DataMember]
        public string HQCode { get; set; }

        [JsonPropertyName("HQName")]
        [DataMember]
        public string HQName { get; set; }

        [JsonPropertyName("HQShortName")]
        [DataMember]
        public string HQShortName { get; set; }

        [JsonPropertyName("ModifiedBy")]
        [DataMember]
        public int ModifiedBy { get; set; }
    }

    public class UpdateHQModelOutput : BaseClassOutput
    {

    }

    public class DeleteHQModelInput
    {
        [JsonPropertyName("HQID")]
        [DataMember]
        public int HQID { get; set; }

      
    }

    public class DeleteHQModelOutput : BaseClassOutput
    {

    }
}