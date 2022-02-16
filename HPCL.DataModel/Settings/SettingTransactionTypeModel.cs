using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HPCL.DataModel.Settings
{

    public class SettingGetTransactionTypeModelInput : BaseClass
    {

    }
    public class SettingGetTransactionTypeModelOutput
    {
        [JsonProperty("TransactionID")]
        [DataMember]
        public int TransactionID { get; set; }

        [JsonProperty("TransactionType")]
        [DataMember]
        public string TransactionType { get; set; }
    }

   
}
