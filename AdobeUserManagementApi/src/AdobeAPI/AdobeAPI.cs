using AdobeUserManagementApi.src.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.AdobeAPI
{
    public class AdobeAPI : IAdobeAPI
    {
        private readonly string _adobeOrgID;

        public HttpClient _httpClient { get; }

        public AdobeAPI(HttpClient httpClient, string adobeOrgID, ILogger<AdobeAPI> logger)
        {
            _httpClient = httpClient;
            _adobeOrgID = adobeOrgID;
        }

        public async Task<T> GetAdobeDataAsync<T>(string url, CancellationToken cancellationtoken)
        {
            var response = await _httpClient.GetAsync($"/v2/usermanagement/organizations/{_adobeOrgID}/{url}", cancellationtoken);

            return ResponseReturn<T>(response);

        }

        public async Task<AdobePostResponse> PostAdobeAsync(HttpContent content, CancellationToken cancellationtoken)
        {

            var response = await _httpClient.PostAsync($"/v2/usermanagement/action/{_adobeOrgID}", content, cancellationtoken);

            return ResponseReturn<AdobePostResponse>(response);

        }

        public async Task<AdobePostResponse?> TestPostAdobeAsync(HttpContent content, CancellationToken cancellationtoken)
        {

            var response = await _httpClient.PostAsync($"/v2/usermanagement/action/{_adobeOrgID}?testOnly=true", content, cancellationtoken);

            return ResponseReturn<AdobePostResponse>(response);

        }

        private static T? ResponseReturn<T>(HttpResponseMessage httpResponseMessage)
        {
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var responseStream = httpResponseMessage.Content.ReadAsStringAsync().Result;

                return JsonSerializer.Deserialize<T>(responseStream);
            }
            else
                return default;
        }
    }
}
