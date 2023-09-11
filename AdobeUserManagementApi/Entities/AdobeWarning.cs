using System.Text.Json.Serialization;

namespace AdobeUserManagementApi.Models
{
    public sealed class AdobeWarning
    {
        [JsonPropertyName("warningCode")]
        public string WarningCode { get; }
        [JsonPropertyName("requestID")]
        public string RequestID { get; }
        [JsonPropertyName("index")]
        public int Index { get; }
        [JsonPropertyName("step")]
        public int Step { get; }
        [JsonPropertyName("message")]
        public string Message { get; }
        [JsonPropertyName("user")]
        public string User { get; }
    }
}
