using AdobeUserManagementApi.AdobeAPI.InterFaces;
using AdobeUserManagementApi.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.AdobeAPI.Concrete
{
    public sealed class AdobePostClient : ApiRateLimiter, IAdobePostClient
    {
        private readonly AdobeAPIClient _adobeAPIClient;


        public AdobePostClient(AdobeAPIClient adobeAPIClient, int maxRequestsPerMinute) : base(maxRequestsPerMinute)
        {
            _adobeAPIClient = adobeAPIClient;
        }

        public async Task<AdobePostResponse> AdobeTryPostAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            await CheckIfRequestsIsOutOfBound();

            return await _adobeAPIClient.CallAdobeUserManagementAPI<AdobePostResponse>(httpRequestMessage, cancellationToken);

        }

    }
}

