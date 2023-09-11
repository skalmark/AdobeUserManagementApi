using AdobeUserManagementApi.Models.Groups;
using AdobeUserManagementApi.Requests.Serilizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Requests.POST.Groups
{
    internal abstract class AbstractPost
    {
        private readonly string _adobeOrgID;
        private readonly string _adobeBaseUrl;
        internal AbstractPost(string adobeOrgID, string adobeBaseUrl)
        {
            _adobeOrgID = adobeOrgID;
            _adobeBaseUrl = adobeBaseUrl;
        }

        internal List<T> SplitMembers<T>(List<T> members)
        {

            return members;
        }

        internal HttpRequestMessage GenereateHttpRequestMessage<T>(T @object) => new()
        {
            RequestUri = new Uri($"{_adobeBaseUrl}/v2/usermanagement/action/{_adobeOrgID}"),
            Content = new StringContent(ConverToJson.ConvertToJson(@object), Encoding.UTF8, "application/json"),
            Method = HttpMethod.Post
        };
    }
}
