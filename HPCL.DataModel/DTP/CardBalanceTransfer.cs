using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.DTP
{
   
    public class CardBalanceTransferModelInput
    {
        [Required]
        [JsonPropertyName("CardStatus")]
        [DataMember]
        public int CardStatus { get; set; }

        [Required]
        [JsonPropertyName("CardNo")]
        [DataMember]
        public string Cardno { get; set; }
    }

    public class CardBalanceTransferModelOutput : BaseClassOutput
    {

    }

}
