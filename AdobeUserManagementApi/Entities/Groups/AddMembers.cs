using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Models.Groups
{
    public sealed class AddMembersModel
    {
        public AddMembersModel(List<string> members)
        {
            AddMembers = new AddMembers(members);
        }
        [JsonPropertyName("add")]
        public AddMembers AddMembers { get; }
    }

    public sealed class AddMembers
    {
        public AddMembers(List<string> members)
        {
            Members = members;
        }
        [JsonPropertyName("user")]
        public List<string> Members { get; }
    }
}
