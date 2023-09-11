using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdobeUserManagementApi.AdobeAPI.InterFaces;
using AdobeUserManagementApi.Models;
using AdobeUserManagementApi.Models.Groups;
using AdobeUserManagementApi.Requests.Serilizer;

namespace AdobeUserManagementApi.Requests.POST.Groups.Update
{
    internal sealed class AddGroupMembers : AbstractPost
    {
        private readonly IAdobePostClient _adobeAPI;

        internal AddGroupMembers(IAdobePostClient adobeAPI, string adobeOrgID, string adobeBaseUrl) : base (adobeOrgID, adobeBaseUrl)
        {
            _adobeAPI = adobeAPI;
        }

        internal async Task<AdobePostResponse> AddMembers(string groupName, List<string> members, CancellationToken cancellationToken)
        {
            //Limit of 10 users per request

            if(members.Count > 10)
            {

            }

            UpdateGroupMembers<AddMembersModel> updateGroupMembers = new()
            {
                Usergroup = groupName,
                Do = new List<AddMembersModel>()
                {
                    new AddMembersModel(members)
                }
            };

            
            return await _adobeAPI.AdobeTryPostAsync(GenereateHttpRequestMessage(updateGroupMembers), cancellationToken);
        }


    }
}
