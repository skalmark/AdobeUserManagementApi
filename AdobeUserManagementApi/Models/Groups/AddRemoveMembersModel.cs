using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Models.Groups
{
    public class AddRemoveMembersModel
    {
        public AddRemoveMembersModel(List<string> addMembers, List<string> removeMembers)
        {
            AddMembers = new AddMembers(addMembers);
            RemoveMembers = new RemoveMembers(removeMembers);
        }
        [JsonPropertyName("add")]
        public AddMembers AddMembers { get; }
        [JsonPropertyName("remove")]
        public RemoveMembers RemoveMembers { get; }
    }
}
