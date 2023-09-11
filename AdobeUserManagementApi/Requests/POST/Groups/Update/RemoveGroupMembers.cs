using AdobeUserManagementApi.AdobeAPI.InterFaces;
using AdobeUserManagementApi.Models;
using AdobeUserManagementApi.Models.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Requests.POST.Groups.Update
{
    public class RemoveGroupMembers
    {
        private readonly IAdobePostClient _adobeAPI;

        public RemoveGroupMembers(IAdobePostClient adobeAPI)
        {
            _adobeAPI = adobeAPI;
        }

        public async Task<AdobePostResponse> RemoveMembers(string groupName, List<string> members, CancellationToken cancellationToken)
        {
            //Limit of 10 users per request

            UpdateGroupMembers<RemoveMembersModel> updateGroupMembers = new()
            {
                Usergroup = groupName,
                Do = new List<RemoveMembersModel>()
                {
                    new RemoveMembersModel(members)
                }
            };

            return new AdobePostResponse();
        }
    }
}
