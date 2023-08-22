using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AdobeUserManagementApi.Models;

namespace AdobeUserManagementApi.Models.Groups
{
    public sealed class UpdateGroupMembers<T> : AdobeDoModel<T> where T : class
    {
        [JsonPropertyName("usergroup")]
        public string Usergroup { get; set; }
    }
}
