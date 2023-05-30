using AdobeUserManagementApi.src.Responses.Users;
using System.Text.Json.Serialization;


namespace AdobeUserManagementApi.src.Models.Users
{
    public class CreateUserAdobeID
    {
        public CreateUserAdobeID(CreateUserBase createUserBase)
        {
            AddAdobeID = createUserBase;
        }
        [JsonPropertyName("addAdobeID")]
        public CreateUserBase AddAdobeID { get; }
    }

    public class CreateUserEnterpriseID
    {
        public CreateUserEnterpriseID(CreateUserBase createUserBase)
        {
            CreateEnterpriseID = createUserBase;
        }

        [JsonPropertyName("createEnterpriseID")]
        public CreateUserBase CreateEnterpriseID { get; }
    }

    public class CreateUserFederatedID
    {
        public CreateUserFederatedID(CreateUserBase createUserBase)
        {
            CreateFederatedID = createUserBase;
        }

        [JsonPropertyName("createFederatedID")]
        public CreateUserBase CreateFederatedID { get; }
    }
}
