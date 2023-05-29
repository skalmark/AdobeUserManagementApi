using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
        [JsonPropertyName("Email")]
        public string email { get; }
        [JsonPropertyName("status")]
        public string Status { get; }
        [JsonPropertyName("country")]
        public string Country { get; }
        [JsonPropertyName("Groups")]
        public List<string> groups { get; }
        [JsonPropertyName("adminRoles")]
        public List<string> AdminRoles { get; }
        [JsonPropertyName("domain")]
        public string Domain { get; }
        [JsonPropertyName("type")]
        public string Type { get;  }
    }
}
