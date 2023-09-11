using AdobeUserManagementApi.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using static AdobeUserManagementApi.AdobeAPI.Concrete.AdobeToken;

namespace AdobeUserManagementApi.AdobeAPI.Concrete
{
    public sealed class AdobeToken
    {
        private const string _baseUrl = "https://ims-na1.adobelogin.com/ims/token/v3?client_id=";

        private readonly IOptions<AdobeAPISettings> adobeAPISettings;

        private readonly HttpClient _httpClient;
        public AdobeToken(HttpClient httpClient, IOptions<AdobeAPISettings> adobeAPISettings)
        {
            _httpClient = httpClient;
            this.adobeAPISettings = adobeAPISettings;
        }

        internal async Task<AuthenticationHeaderValue> GetAdobeToken(CancellationToken cancellationToken)
        {
            if (adobeAPISettings.Value.OauthToken == string.Empty)
            {
                return await GenerateToken(cancellationToken);
            }
            else if (adobeAPISettings.Value.TokenLifeTime < DateTimeOffset.Now)
            {
                return await GenerateToken(cancellationToken);
            }

            return GenerateHeader(adobeAPISettings.Value.OauthToken);
        }

        private async Task<AuthenticationHeaderValue> GenerateToken(CancellationToken cancellationToken)
        {
            var adobePostBody = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("client_secret", adobeAPISettings.Value.ClientSecret),
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("scope", "openid,AdobeID,user_management_sdk")
            };

            var getAdobeToken = await _httpClient.SendAsync(new HttpRequestMessage()
            {
                RequestUri = new Uri(_baseUrl + adobeAPISettings.Value.Clientid),
                Method = HttpMethod.Post,
                Content = new FormUrlEncodedContent(adobePostBody)
            }, cancellationToken);


            getAdobeToken.EnsureSuccessStatusCode();
            var readResponse = getAdobeToken.Content.ReadAsStringAsync(cancellationToken).Result;

            adobeAPISettings.Value.OauthToken = JsonSerializer.Deserialize<Token>(readResponse).access_token;
            adobeAPISettings.Value.TokenLifeTime = DateTimeOffset.Now.AddHours(12);

            return GenerateHeader(adobeAPISettings.Value.OauthToken);
        }

        private static AuthenticationHeaderValue GenerateHeader(string token)
        {
            return new AuthenticationHeaderValue("Bearer", token);
        }

        public class Token
        {
            public string access_token { get; set; }
        }
    }
}
