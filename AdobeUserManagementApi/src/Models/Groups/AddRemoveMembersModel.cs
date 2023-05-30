using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models.Groups
{
    public class AddRemoveMembersModel
    {
        public AddMembersModel AddMembers { get; set; }
        public RemoveMembersModel RemoveMembers { get; set; }
    }
}
