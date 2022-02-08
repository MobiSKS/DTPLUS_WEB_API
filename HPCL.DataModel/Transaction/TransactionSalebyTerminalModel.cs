using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Transaction
{
   

    public class TransactionSalebyTerminalModelInput : BaseClass
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

        [JsonPropertyName("Batchid")]
        [DataMember]
        public Int64 Batchid { get; set; }

        [JsonPropertyName("Amount")]
        [DataMember]
        public float Amount { get; set; }

        [JsonPropertyName("Type")]
        [DataMember]
        public string Type { get; set; }


        [JsonPropertyName("Transid")]
        [DataMember]
        public string Transid { get; set; }

        [JsonPropertyName("Transdate")]
        [DataMember]
        public DateTime Transdate { get; set; }


        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }


        [JsonPropertyName("Productid")]
        [DataMember]
        public int Productid { get; set; }

        [JsonPropertyName("Odometerreading")]
        [DataMember]
        public string Odometerreading { get; set; }


        [JsonPropertyName("OTP")]
        [DataMember]
        public string OTP { get; set; }


        [JsonPropertyName("Pin")]
        [DataMember]
        public string Pin { get; set; }


        [JsonPropertyName("Source")]
        [DataMember]
        public string Source { get; set; }

        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }
    public class TransactionSalebyTerminalModelOutput :BaseClassOutput
    {
        
    }


    public class RechargeCCMSAccountModelInput : BaseClass
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

        [JsonPropertyName("Batchid")]
        [DataMember]
        public Int64 Batchid { get; set; }

        [JsonPropertyName("Amount")]
        [DataMember]
        public float Amount { get; set; }

        [JsonPropertyName("Type")]
        [DataMember]
        public string Type { get; set; }


        [JsonPropertyName("Transid")]
        [DataMember]
        public string Transid { get; set; }

        [JsonPropertyName("Transdate")]
        [DataMember]
        public DateTime Transdate { get; set; }


        [JsonPropertyName("Chequeno")]
        [DataMember]
        public string Chequeno { get; set; }


        [JsonPropertyName("MICR")]
        [DataMember]
        public string MICR { get; set; }


        [JsonPropertyName("MUtrno")]
        [DataMember]
        public string MUtrno { get; set; }


        [JsonPropertyName("Paymentmode")]
        [DataMember]
        public string Paymentmode { get; set; }


        [JsonPropertyName("Currency")]
        [DataMember]
        public string Currency { get; set; }


        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }

        [JsonPropertyName("OTP")]
        [DataMember]
        public string OTP { get; set; }


        [JsonPropertyName("Pin")]
        [DataMember]
        public string Pin { get; set; }


        [JsonPropertyName("Source")]
        [DataMember]
        public string Source { get; set; }

        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }
    public class RechargeCCMSAccountModelOutput : BaseClassOutput
    {

    }


    public class GetBatchnoModelInput : BaseClass
    {
        [JsonPropertyName("Merchantid")]
        [DataMember]
        public string Merchantid { get; set; }

        [JsonPropertyName("Terminalid")]
        [DataMember]
        public string Terminalid { get; set; }

        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }
    }
    public class GetBatchnoModelOutput : BaseClassOutput
    {

    }
}
