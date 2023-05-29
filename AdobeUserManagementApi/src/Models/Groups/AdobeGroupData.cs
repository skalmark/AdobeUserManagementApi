using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models.Groups
{
    public class AdobeGroupData
    {
        [JsonPropertyName("groupId")]
        public int GroupId { get; set; }
        [JsonPropertyName("groupName")]
        public string GroupName { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("memberCount")]
        public int MemberCount { get; set; }
        [JsonPropertyName("adminGroupName")]
        public string AdminGroupName { get; set; }
        [JsonPropertyName("productName")]
        public string ProductName { get; set; }
        [JsonPropertyName("licenseQuota")]
        public string LicenseQuota { get; set; }
    }
}
