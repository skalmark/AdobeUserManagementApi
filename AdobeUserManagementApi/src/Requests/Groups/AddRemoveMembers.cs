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
    public class AddRemoveMembers
    {

        private readonly IAdobeAPI _adobeAPI;

        public AddRemoveMembers(IAdobeAPI adobeAPI)
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
                    new AddRemoveMembersModel()
                    {
                        AddMembers = new AddMembersModel()
                        {
                            AddMembers = new AddMembers(Addmembers)
                        },
                        RemoveMembers = new RemoveMembersModel()
                        {
                             RemoveMembers = new RemoveMembers(removeMembers)
                        }
                    }
                }
            };

            return new AdobePostResponse();
        }
    }
}
