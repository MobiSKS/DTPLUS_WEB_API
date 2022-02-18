using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Customer
{
    public class CheckEmailIdModelInput : BaseClass
    {
        [JsonPropertyName("CommunicationEmailid")]
        [DataMember]
        public string CommunicationEmailid { get; set; }
    }
    public class CheckEmailIdModelOutput : BaseClassOutput
    {

    }
}
