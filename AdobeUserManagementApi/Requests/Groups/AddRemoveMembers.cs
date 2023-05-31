using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdobeUserManagementApi.AdobeAPI;
using AdobeUserManagementApi.Models;
using AdobeUserManagementApi.Models.Groups;

namespace AdobeUserManagementApi.Requests.Groups
{
    public class AddRemoveMembers
    {

        private readonly IAdobeAPIClient _adobeAPI;

        public AddRemoveMembers(IAdobeAPIClient adobeAPI)
        {
            _adobeAPI = adobeAPI;
        }

        public async Task<AdobePostResponse> AddMembers(string groupName, List<string> Addmembers, List<string> removeMembers)
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
