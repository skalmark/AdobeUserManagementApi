﻿using Microsoft.Extensions.Configuration;
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
    public class AdobeAPI
    {
        private readonly string _adobeOrgID;

        public HttpClient _httpClient { get; }

        public AdobeAPI(HttpClient httpClient, IConfiguration configuration, ILogger<AdobeAPI> logger)
        {
            _httpClient = httpClient;
            _adobeOrgID = configuration["AdobeAPI:OrgID"];
            httpClient.BaseAddress = new Uri(configuration["AdobeAPI:uri"]);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", configuration["AdobeAPI:ClientID"]);
        }

        public AdobeAPI(HttpClient httpClient, string adobeOrgID, ILogger<AdobeAPI> logger) 
        {
            _httpClient = httpClient;
            _adobeOrgID = adobeOrgID;
        }

        internal async Task<T> GetAdobeDataAsync<T>(string url, CancellationToken cancellationtoken)
        {

            //await CheckToken();
            var response = await _httpClient.GetAsync($"/v2/usermanagement/organizations/{_adobeOrgID}/{url}", cancellationtoken);

            return ResponseReturn<T>(response);

        }

        private static T ResponseReturn<T>(HttpResponseMessage httpResponseMessage)
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
