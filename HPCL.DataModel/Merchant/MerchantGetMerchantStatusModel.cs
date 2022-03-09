using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace HPCL.DataModel.Merchant
{
    public class MerchantGetMerchantStatusModelInput : BaseClass
    {

    }

    public class MerchantGetMerchantStatusModelOutput
    {
        [JsonProperty("StatusId")]
        [DataMember]
        public int StatusId { get; set; }


        [JsonProperty("StatusName")]
        [DataMember]
        public string StatusName { get; set; }
    }
}
