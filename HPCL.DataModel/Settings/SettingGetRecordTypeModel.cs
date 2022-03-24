using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{
    public class SettingGetRecordTypeModelInput : BaseClass
    {

    }
    public class SettingGetRecordTypeModelOutput
    {
        [JsonPropertyName("EntityId")]
        [DataMember]
        public int EntityId { get; set; }


        [JsonPropertyName("EntityName")]
        [DataMember]
        public string EntityName { get; set; }
    }
}
