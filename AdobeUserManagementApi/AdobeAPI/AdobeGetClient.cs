using AdobeUserManagementApi.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.AdobeAPI
{
    public class AdobeGetClient : RateLimiter, IAdobeGetClient
    {
        private readonly AdobeAPIClient _adobeAPIClient;


        public AdobeGetClient(AdobeAPIClient adobeAPIClient, int maxRequests) : base(maxRequests)
        {
            _adobeAPIClient = adobeAPIClient;
        }

        public async Task<T> AdobeTryGetAsync<T>(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            await CheckIfRequestsIsOutOfBound();

            return await _adobeAPIClient.CallAdobeUserManagementAPI<T>(httpRequestMessage, cancellationToken);

        }

    }
}
