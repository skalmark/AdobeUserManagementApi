using AdobeUserManagementApi.AdobeAPI.InterFaces;
using AdobeUserManagementApi.Models;
using AdobeUserManagementApi.Models.Users;
using System.Text;

namespace AdobeUserManagementApi.Requests.Users
{
    public class CreateAdobeUserRequest
    {
        private readonly IAdobeAPIClient _adobeAPI;

        public CreateAdobeUserRequest(IAdobeAPIClient adobeAPI)
        {
            _adobeAPI = adobeAPI;
        }

        public async Task<AdobePostResponse> CreateAdobeUser(CreateUserBase createUserBase, UserType userType, CancellationToken cancellationToken = default)
        {
            string postMessage = GeneratePostMessage(createUserBase, userType);

            return new AdobePostResponse();
            //return await _adobeAPI.PostAdobeAsync(new StringContent(postMessage, Encoding.UTF8, "application/json"), cancellationToken);
        }

        private static string GeneratePostMessage(in CreateUserBase createUserBase, UserType userType)
        {

            if (userType == UserType.AdobeID)
            {
                return GenerateAdobeUserPostJson<CreateUserAdobeID>.GenerateAdobeUserPostJsonData(createUserBase.EmailAddress, new CreateUserAdobeID(createUserBase));
            }
            else if (userType == UserType.EnterPriseID)
            {
                return GenerateAdobeUserPostJson<CreateUserEnterpriseID>.GenerateAdobeUserPostJsonData(createUserBase.EmailAddress, new CreateUserEnterpriseID(createUserBase));
            }

            return GenerateAdobeUserPostJson<CreateUserFederatedID>.GenerateAdobeUserPostJsonData(createUserBase.EmailAddress, new CreateUserFederatedID(createUserBase));

        }
    }
}

