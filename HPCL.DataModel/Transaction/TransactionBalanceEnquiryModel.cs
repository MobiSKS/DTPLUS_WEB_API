using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Transaction
{

    public class TransactionBalanceEnquiryModelInput : BaseClass
    {
        [JsonPropertyName("Merchantid")]
        [DataMember]
        public string Merchantid { get; set; }

        [JsonPropertyName("Terminalid")]
        [DataMember]
        public string Terminalid { get; set; }

        [JsonPropertyName("Cardno")]
        [DataMember]
        public string Cardno { get; set; }


        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }
        

        [JsonPropertyName("OTP")]
        [DataMember]
        public string OTP { get; set; }


        [JsonPropertyName("Pin")]
        [DataMember]
        public string Pin { get; set; }


        [JsonPropertyName("Sourceid")]
        [DataMember]
        public int Sourceid { get; set; }

        [JsonPropertyName("Formfactor")]
        [DataMember]
        public int Formfactor { get; set; }


        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }
    public class TransactionBalanceEnquiryModelOutput : BaseClassOutput
    {

    }
}
