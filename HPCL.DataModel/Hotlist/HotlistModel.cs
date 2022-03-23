using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Hotlist
{

    public class GetActionListInput : BaseClass
    {
        [JsonPropertyName("EntityTypeId")]
        [DataMember]
        public int EntityTypeId { get; set; }
    }
    public class GetActionListOutput
    {
        [JsonProperty("EntityTypeId")]
        [DataMember]
        public int EntityTypeId { get; set; }

        [JsonProperty("StatusId")]
        [DataMember]
        public int StatusId { get; set; }

        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }

      
    }

    public class GetEntityTypeListInput : BaseClass
    {
         
    }
    public class GetEntityTypeListOutput
    {
        [JsonProperty("EntityId")]
        [DataMember]
        public int EntityId { get; set; }


        [JsonProperty("EntityName")]
        [DataMember]
        public string EntityName { get; set; }


    }

    public class GetReasonListForEntitiesInput : BaseClass
    {
        [JsonPropertyName("EntityTypeId")]
        [DataMember]
        public int EntityTypeId { get; set; }

        [JsonPropertyName("Actionid")]
        [DataMember]
        public int Actionid { get; set; }
    }
    public class GetReasonListForEntitiesOutput
    {
        [JsonProperty("EntityTypeId")]
        [DataMember]
        public int EntityTypeId { get; set; }

        [JsonProperty("StatusId")]
        [DataMember]
        public int StatusId { get; set; }

        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }


    }
}
