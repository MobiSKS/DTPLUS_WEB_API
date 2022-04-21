using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace HPCL.DataModel.Settings
{
    public class SettingGetRecordTypeModelInput : BaseClass
    {

    }
    public class SettingGetRecordTypeModelOutput
    {
        [JsonProperty("EntityId")]
        [DataMember]
        public int EntityId { get; set; }


        [JsonProperty("EntityName")]
        [DataMember]
        public string EntityName { get; set; }
    }
}
