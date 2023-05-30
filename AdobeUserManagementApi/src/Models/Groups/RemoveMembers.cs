using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models.Groups
{
    public class RemoveMembersModel
    {
        public RemoveMembersModel(List<string> members)
        {
            RemoveMembers = new RemoveMembers(members);
        }
        [JsonPropertyName("remove")]
        public RemoveMembers RemoveMembers { get; }
    }

    public class RemoveMembers
    {
        public RemoveMembers(List<string> members)
        { 
            Members = members;
        }
        [JsonPropertyName("user")]
        public List<string> Members { get; }
    }
}
