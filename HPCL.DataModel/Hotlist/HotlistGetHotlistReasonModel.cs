using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Hotlist
{
    public class HotlistGetHotlistReasonModelInput : BaseClass
    {

    }
    public class HotlistGetHotlistReasonModelOutput
    {
        [JsonProperty("StatusId")]
        [DataMember]
        public int StatusId { get; set; }


        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }


    }

}
