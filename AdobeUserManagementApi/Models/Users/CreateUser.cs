using System.Text.Json.Serialization;


namespace AdobeUserManagementApi.Models.Users
{
    public sealed class CreateUserAdobeID
    {
        public CreateUserAdobeID(CreateUserBase createUserBase)
        {
            AddAdobeID = createUserBase;
        }
        [JsonPropertyName("addAdobeID")]
        public CreateUserBase AddAdobeID { get; }
    }

    public sealed class CreateUserEnterpriseID
    {
        public CreateUserEnterpriseID(CreateUserBase createUserBase)
        {
            CreateEnterpriseID = createUserBase;
        }

        [JsonPropertyName("createEnterpriseID")]
        public CreateUserBase CreateEnterpriseID { get; }
    }

     public sealed class CreateUserFederatedID
    {
        public CreateUserFederatedID(CreateUserBase createUserBase)
        {
            CreateFederatedID = createUserBase;
        }

        [JsonPropertyName("createFederatedID")]
        public CreateUserBase CreateFederatedID { get; }
    }
}
