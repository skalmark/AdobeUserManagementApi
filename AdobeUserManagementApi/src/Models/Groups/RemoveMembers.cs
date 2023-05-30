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
        [JsonPropertyName("remove")]
        public RemoveMembers RemoveMembers { get; set; }
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
