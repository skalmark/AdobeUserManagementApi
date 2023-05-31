using System.Text.Json.Serialization;


namespace AdobeUserManagementApi.src.Models.Users
{
    public class AdobeUser
    {
        [JsonPropertyName("id")]
        public string AdobeID { get; }
        [JsonPropertyName("firstname")]
        public string Firstname { get; }
        [JsonPropertyName("lastname")]
        public string Lastname { get; }
        [JsonPropertyName("username")]
        public string Username { get; }
        [JsonPropertyName("email")]
        public string Email { get; }
        [JsonPropertyName("status")]
        public string Status { get; }
        [JsonPropertyName("country")]
        public string Country { get; }
        [JsonPropertyName("groups")]
        public List<string> Groups { get; }
        [JsonPropertyName("adminRoles")]
        public List<string> AdminRoles { get; }
        [JsonPropertyName("domain")]
        public string Domain { get; }
        [JsonPropertyName("type")]
        public string Type { get;  }
    }
}


