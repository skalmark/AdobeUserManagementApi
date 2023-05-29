using System.Text.Json.Serialization;

namespace AdobeUserManagementApi.src.Models
{
    public class AdobeGetResponse<T> where T : class
    {
        [JsonPropertyName("lastPage")]
        public bool LastPage { get; }
        [JsonPropertyName("result")]
        public string? Result { get; }
        [JsonPropertyName("data")]
        public List<T>? Data { get; }
    }

}
