using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Web.Http.ModelBinding;

namespace HPCL.Infrastructure.Response
{
    [Serializable]
    [DataContract]
    public class ApiResponseMessage
    {
        #region Public properties.
        /// <summary>
        /// Get/Set property for accessing Status Code
        /// </summary>
        [JsonProperty("Success")]
        [DataMember]
        public bool Success { get; set; }
        /// <summary>
        /// Get/Set property for accessing Status Code
        /// </summary>
        [JsonProperty("Status_Code")]
        [DataMember]
        public int Status_Code { get; set; }

        [JsonProperty("Internel_Status_Code")]
        [DataMember]
        public int Internel_Status_Code { get; set; }
        /// <summary>
        /// Get/Set property for accessing Status Message
        /// </summary>
        [JsonProperty("Message")]
        [DataMember]
        public string Message { get; set; }
        /// <summary>
        /// Get/Set property for accessing Status Message
        /// </summary>
        [JsonProperty("Method_Name")]
        [DataMember]
        public string Method_Name { get; set; }
        /// <summary>
        /// Get/Set property for accessing Status Message
        /// </summary>
        [JsonProperty("Data")]
        [DataMember]
        public object Data { get; set; }

        [JsonProperty("Model_State")]
        [DataMember]
        public ModelStateDictionary Model_State { get; set; }


        #endregion
    }
}
