using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;


namespace HPCL.DataModel.Transaction
{
    public class TransactionCardFeePaymentModelInput : BaseClass
    {
        [JsonPropertyName("Merchantid")]
        [DataMember]
        public string Merchantid { get; set; }

        [JsonPropertyName("Terminalid")]
        [DataMember]
        public string Terminalid { get; set; }


        [JsonPropertyName("Formno")]
        [DataMember]
        public string Formno { get; set; }


        [JsonPropertyName("Batchid")]
        [DataMember]
        public Int64 Batchid { get; set; }

        [JsonPropertyName("Noofcards")]
        [DataMember]
        public Int32 Noofcards { get; set; }

        [JsonPropertyName("Invoiceamount")]
        [DataMember]
        public double Invoiceamount { get; set; }


        [JsonPropertyName("Transtype")]
        [DataMember]
        public string Transtype { get; set; }


        [JsonPropertyName("Invoiceid")]
        [DataMember]
        public string Invoiceid { get; set; }


        [JsonPropertyName("Invoicedate")]
        [DataMember]
        public DateTime Invoicedate { get; set; }

        [JsonPropertyName("Sourceid")]
        [DataMember]
        public string Sourceid { get; set; }


        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }

    }

    public class TransactionCardFeePaymentModelOutput : BaseClassOutput
    {

    }
}
