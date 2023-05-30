using AdobeUserManagementApi.src.AdobeAPI;
using AdobeUserManagementApi.src.Models.Groups;
using AdobeUserManagementApi.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Requests.Groups
{
    public class AddGroupMembers
    {
        private readonly IAdobeAPI _adobeAPI;

        public AddGroupMembers(IAdobeAPI adobeAPI)
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
