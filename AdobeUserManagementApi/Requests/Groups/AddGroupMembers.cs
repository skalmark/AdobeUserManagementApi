using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdobeUserManagementApi.AdobeAPI.InterFaces;
using AdobeUserManagementApi.Models;
using AdobeUserManagementApi.Models.Groups;

namespace AdobeUserManagementApi.Requests.Groups
{
    public class AddGroupMembers
    {
        private readonly IAdobeAPIClient _adobeAPI;

        public AddGroupMembers(IAdobeAPIClient adobeAPI)
        {
            _adobeAPI = adobeAPI;
        }

        public async Task<AdobePostResponse> AddMembers(string groupName, List<string> members)
        {
            //Limit of 10 users per request

            UpdateGroupMembers<AddMembersModel> updateGroupMembers = new()
            {
                Usergroup = groupName,
                Do = new List<AddMembersModel>()
                {
                    new AddMembersModel(members)
                }
            };

            return new AdobePostResponse();
        }
    }
}
