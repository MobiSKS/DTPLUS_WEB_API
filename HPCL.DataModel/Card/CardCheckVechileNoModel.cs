using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Card
{

    public class CardCheckVechileNoModelInput : BaseClass
    {
        [JsonPropertyName("VechileNo")]
        [DataMember]
        public string VechileNo { get; set; }
    }
    public class CardCheckVechileNoModelOutput : BaseClassOutput
    {

    }
}
