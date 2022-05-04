using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HPCL.DataModel.Card
{
    public class TransferAmountCCMSToCardModelInput:BaseClass
    {
        [Required]
        [JsonPropertyName("CustomerId")]
        [DataMember]
        public string CustomerId { get; set; }
        public List<CCMSToCardTransfer> CCMSToCardTransfer { get; set; }

    }
    public class CCMSToCardTransfer
    {
        public string CardNo { get; set; }
        public float TransferAmount { get; set; }    
    }

    public class TransferAmountCCMSToCardModelOutput:BaseClassOutput
    {

    }
}
