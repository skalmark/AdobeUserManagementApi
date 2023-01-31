using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models
{
    public class AdobeWarning
    {
        [JsonProperty("warningCode")]
        public string WarningCode { get;  }
        [JsonProperty("requestID")]
        public string RequestID { get; }
        [JsonProperty("index")]
        public int Index { get; }
        [JsonProperty("step")]
        public int Step { get; }
        [JsonProperty("message")]
        public string Message { get; }
        [JsonProperty("user")]
        public string User { get; }
    }
}
