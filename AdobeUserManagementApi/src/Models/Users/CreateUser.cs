using AdobeUserManagementApi.src.Calls.AdobeUser;
using AdobeUserManagementApi.src.Responses.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models.Users
{
    public class CreateUser<T> : AdobeDoModel<T> where T : class
    {
        public CreateUser(string user, string requestID)
        { 
            User = user;
            RequestID = requestID;
        }
        public string User { get;  }
        public string RequestID { get; }

    }

    public class CreateUserAdobeID
    {
        [JsonPropertyName("addAdobeID")]
        public CreateUserBase AddAdobeID { get; set; }
    }

    public class CreateUserEnterpriseID
    {
        [JsonPropertyName("createEnterpriseID")]
        public CreateUserBase CreateEnterpriseID { get; set; }
    }

    public class CreateUserFederatedID
    {
        [JsonPropertyName("createFederatedID")]
        public CreateUserBase CreateFederatedID { get; set; }
    }
}
