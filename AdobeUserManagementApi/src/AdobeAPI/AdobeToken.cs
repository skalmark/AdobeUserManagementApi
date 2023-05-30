using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.AdobeAPI
{
    public class AdobeToken
    {
        private const string _baseUrl = "https://ims-na1.adobelogin.com/ims/token/v3?client_id=";

        private readonly ILogger<AdobeToken> _logger;
        public HttpClient _httpClient { get; }
        public AdobeToken(HttpClient httpClient, ILogger<AdobeToken> logger)
        {
            _httpClient = httpClient;
        }

        internal async Task<string> GetAdobeToken()
        {
            var AdobeParams = new Dictionary<string, string>
            {
                { "client_id", "AdobeAPI:ClientID" },
                { "client_secret", "AdobeAPI:ClientSecret" },
                { "jwt_token", "" }
            };

            var getAdobeToken = await _httpClient.PostAsync("", new FormUrlEncodedContent(AdobeParams));
            getAdobeToken.EnsureSuccessStatusCode();
            var readResponse = getAdobeToken.Content.ReadAsStringAsync().Result;

            var tokens = JsonSerializer.Deserialize<Token>(readResponse);

            return tokens.access_token;

           
        }



        public class Token
        {
            public string? access_token { get; set; }
        }
    }
}
