using AdobeUserManagementApi.src.AdobeAPI;
using AdobeUserManagementApi.src.Models;
using AdobeUserManagementApi.src.Models.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Requests.Groups
{
    public class RemoveGroupMembers
    {
        private readonly IAdobeAPI _adobeAPI;

        public RemoveGroupMembers(IAdobeAPI adobeAPI)
        {
            _adobeAPI = adobeAPI;
        }

        public async Task<AdobePostResponse> RemoveMembers(string groupName, List<string> members)
        {
            //Limit of 10 users per request

            UpdateGroupMembers<RemoveMembersModel> updateGroupMembers = new()
            {
                Usergroup = groupName,
                Do = new List<RemoveMembersModel>()
                {
                    new RemoveMembersModel()
                    {
                        RemoveMembers = new RemoveMembers(members)
                    }
                }
            };

            return new AdobePostResponse();
        }
    }
}
