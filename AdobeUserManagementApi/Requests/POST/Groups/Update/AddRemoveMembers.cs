using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdobeUserManagementApi.AdobeAPI.InterFaces;
using AdobeUserManagementApi.Models;
using AdobeUserManagementApi.Models.Groups;

namespace AdobeUserManagementApi.Requests.POST.Groups.Update
{
    internal class AddRemoveMembers
    {

        private readonly IAdobePostClient _adobeAPI;

        internal AddRemoveMembers(IAdobePostClient adobeAPI)
        {
            _adobeAPI = adobeAPI;
        }

        internal async Task<AdobePostResponse> AddMembers(string groupName, List<string> Addmembers, List<string> removeMembers, CancellationToken cancellationToken)
        {
            //Limit of 10 users per request

            UpdateGroupMembers<AddRemoveMembersModel> updateGroupMembers = new()
            {
                Usergroup = groupName,
                Do = new List<AddRemoveMembersModel>()
                {
                    new AddRemoveMembersModel(Addmembers,removeMembers)
                }
            };

            return new AdobePostResponse();
        }
    }
}
