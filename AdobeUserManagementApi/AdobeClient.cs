using AdobeUserManagementApi.AdobeAPI.InterFaces;
using AdobeUserManagementApi.Options;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi
{
    public sealed class AdobeClient
    {
        private readonly IAdobeGetClient _adobeGetClient;
        private readonly IAdobePostClient _adobePostClient;
        private readonly string _adobeOrgID;
        private readonly string _adobeOrgID;

        public AdobeClient(IAdobeGetClient adobeGetClient, IAdobePostClient adobePostClient, IOptions<AdobeAPISettings> adobeAPISettings)
        {
            _adobeGetClient = adobeGetClient;
            _adobePostClient = adobePostClient;
            _adobeOrgID = adobeAPISettings.Value.OrgID;
        }


    }
}
