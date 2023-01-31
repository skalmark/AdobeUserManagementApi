using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models
{
    public class AdobeError
    {
        [JsonProperty("index")]
        public int Index { get; }
        [JsonProperty("step")]
        public int Step { get; }
        [JsonProperty("requestID")]
        public string RequestID { get; }
        [JsonProperty("message")]
        public string Message { get; }
        [JsonProperty("user")]
        public string User { get; }
        // The error type. See https://adobe-apiplatform.github.io/umapi-documentation/en/api/ErrorRef.html for a full list.
        [JsonProperty("errorCode")]
        public string ErrorCode { get; }
    }
}
