﻿using AdobeUserManagementApi.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.AdobeAPI
{
    public class AdobeAPIClient : IAdobeAPIClient
    {
        private readonly AdobeToken _adobeToken;
        private readonly HttpClient _httpClient;

        public AdobeAPIClient(HttpClient httpClient, AdobeToken adobeToken, ILogger<AdobeAPIClient> logger)
        {
            _httpClient = httpClient;
            _adobeToken = adobeToken;
        }

        public async Task<T> CallAdobeUserManagementAPI<T>(HttpRequestMessage httpRequestMessage, CancellationToken cancellationtoken)
        {
            httpRequestMessage.Headers.Authorization = await _adobeToken.GetAdobeToken(cancellationtoken);
            var response = await _httpClient.SendAsync(httpRequestMessage, cancellationtoken);

            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                var responseStream = await response.Content.ReadAsStringAsync(cancellationtoken);

                return JsonSerializer.Deserialize<T>(responseStream);
            }
            else
                return default;

        }

    }
}
