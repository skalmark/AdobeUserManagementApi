using AdobeUserManagementApi.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.AdobeAPI
{
    public class AdobePostClient : RateLimiter
    {
        private readonly AdobeAPIClient _adobeAPIClient;


        public AdobePostClient(AdobeAPIClient adobeAPIClient, int maxRequests) : base (maxRequests) 
        {
            _adobeAPIClient = adobeAPIClient;
        }

        public async Task<AdobePostResponse> AdobeTryPostAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            await ResetIfNeededAsync();

            if (_semaphore.Wait(0, cancellationToken))
            {
                return await _adobeAPIClient.CallAdobeUserManagementAPI<AdobePostResponse>(httpRequestMessage, cancellationToken);
            }

            return new AdobePostResponse(); ; // Rate limit exceeded.

            
        }
        //useractions 10 per minute


    }
}

