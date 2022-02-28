using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Transaction
{
    public class TranscationsCheckForBatchSettlementModelInput :BaseClass
    {
        [Required]
        [JsonPropertyName("Merchantid")]
        [DataMember]
        public string Merchantid { get; set; }

        [Required]
        [JsonPropertyName("Terminalid")]
        [DataMember]
        public string Terminalid { get; set; }


        [Required]
        [JsonPropertyName("Batchid")]
        [DataMember]
        public Int64 Batchid { get; set; }


        [JsonPropertyName("ObjTranscationsForBatchSettlement")]
        [DataMember]
        public List<TranscationsForBatchSettlement> ObjTranscationsForBatchSettlement { get; set; }
    }

    public class TranscationsForBatchSettlement
    {
        [Required]
        [JsonPropertyName("Trantype")]
        [DataMember]
        public string Trantype { get; set; }

        [Required]
        [JsonPropertyName("Transcount")]
        [DataMember]
        public Int32 Transcount { get; set; }


        [Required]
        [JsonPropertyName("Totalamount")]
        [DataMember]
        public double Totalamount { get; set; }
    }

    public class TranscationsCheckForBatchSettlementModelOutput : BaseClassOutput
    {

    }
}
