using System.Text.Json.Serialization;

namespace AdobeUserManagementApi.src.Models
{
    public class AdobeError
    {
        [JsonPropertyName("index")]
        public int Index { get; }
        [JsonPropertyName("step")]
        public int Step { get; }
        [JsonPropertyName("requestID")]
        public string? RequestID { get; }
        [JsonPropertyName("message")]
        public string? Message { get; }
        [JsonPropertyName("user")]
        public string? User { get; }
        [JsonPropertyName("errorCode")]
        public string? ErrorCode { get; }

        // The error type. See https://adobe-apiplatform.github.io/umapi-documentation/en/api/ErrorRef.html for a full list.
    }
}
