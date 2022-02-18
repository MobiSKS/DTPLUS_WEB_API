﻿using Newtonsoft.Json;
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

        [JsonPropertyName("Invoiceamount")]
        [DataMember]
        public float Invoiceamount { get; set; }

        [JsonPropertyName("Transtype")]
        [DataMember]
        public string Transtype { get; set; }


        [JsonPropertyName("Invoiceid")]
        [DataMember]
        public string Invoiceid { get; set; }

        [JsonPropertyName("Invoicedate")]
        [DataMember]
        public DateTime Invoicedate { get; set; }


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


        [JsonPropertyName("Sourceid")]
        [DataMember]
        public string Sourceid { get; set; }

        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }

        [JsonPropertyName("Formfactor")]
        [DataMember]
        public int Formfactor { get; set; }
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


    public class TransactionBalanceTransferModelInput : BaseClass
    {
        [JsonPropertyName("Merchantid")]
        [DataMember]
        public string Merchantid { get; set; }

        [JsonPropertyName("Terminalid")]
        [DataMember]
        public string Terminalid { get; set; }

        [JsonPropertyName("Fromaccount")]
        [DataMember]
        public string Fromaccount { get; set; }

        [JsonPropertyName("Toaccount")]
        [DataMember]
        public string Toaccount { get; set; }


        [JsonPropertyName("Transid")]
        [DataMember]
        public string Transid { get; set; }

        [JsonPropertyName("Transdate")]
        [DataMember]
        public DateTime Transdate { get; set; }


        [JsonPropertyName("Amount")]
        [DataMember]
        public float Amount { get; set; }



        [JsonPropertyName("Type")]
        [DataMember]
        public string Type { get; set; }


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
    public class TransactionBalanceTransferModelOutput : BaseClassOutput
    {

    }

    public class TransactionGenerateOTPModelInput : BaseClass
    {
        [JsonPropertyName("Merchantid")]
        [DataMember]
        public string Merchantid { get; set; }

        [JsonPropertyName("Terminalid")]
        [DataMember]
        public string Terminalid { get; set; }


        [JsonPropertyName("Mobileno")]
        [DataMember]
        public string Mobileno { get; set; }


        [JsonPropertyName("OTPtype")]
        [DataMember]
        public int OTPtype { get; set; }


        [JsonPropertyName("CreatedBy")]
        [DataMember]
        public string CreatedBy { get; set; }

         

    }
    public class TransactionGenerateOTPModelOutput : BaseClassOutput
    {
        
        [JsonProperty("OTP")]
        [DataMember]
        public string OTP { get; set; }
    }
}
