using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models.Groups
{
    public class AddRemoveMembersModel
    {
        public AddRemoveMembersModel(List<string> addMembers, List<string> removeMembers)
        {
            AddMembers = new AddMembersModel(addMembers);
            RemoveMembers = new RemoveMembersModel(removeMembers);
        }
        public AddMembersModel AddMembers { get; }
        public RemoveMembersModel RemoveMembers { get;}
    }
}
