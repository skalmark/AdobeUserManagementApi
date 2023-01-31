using Jose;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _configuration;
        private readonly X509Certificate2 _certificate;
        public HttpClient _httpClient { get; }
        public AdobeToken(HttpClient httpClient, IConfiguration configuration, X509Certificate2 certificate)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _certificate = certificate;
        }

        internal async Task<string> GetAdobeToken()
        {
            var AdobeParams = new Dictionary<string, string>
            {
                { "client_id", _configuration["AdobeAPI:ClientID"] },
                { "client_secret", _configuration["AdobeAPI:ClientSecret"] },
                { "jwt_token", GenereateAdobeAuthJWTToken(_certificate) }
            };

            var getAdobeToken = await _httpClient.PostAsync("", new FormUrlEncodedContent(AdobeParams));
            getAdobeToken.EnsureSuccessStatusCode();
            var readResponse = getAdobeToken.Content.ReadAsStringAsync().Result;

            var tokens = JsonSerializer.Deserialize<Token>(readResponse);

            return tokens.access_token;

           
        }

        private string GenereateAdobeAuthJWTToken(X509Certificate2 certificate)
        {
            Dictionary<object, object> AdobeApisettings = new Dictionary<object, object>
            {
                { "exp", DateTimeOffset.Now.ToUnixTimeSeconds() + 600 },
                { "iss", _configuration["AdobeAPI:OrgID"] },
                { "sub", _configuration["AdobeAPI:TechAccountID"] },
                { "aud", "https://ims-na1.adobelogin.com/c/" + _configuration["AdobeAPI:ClientID"] }
            };
            string[] scopes = "https://ims-na1.adobelogin.com/s/ent_user_sdk".Split(',');


            foreach (string scope in scopes)
            {
                AdobeApisettings.Add(scope, true);
            }


            return JWT.Encode(AdobeApisettings, certificate.GetRSAPrivateKey(), JwsAlgorithm.RS256);
        }

        public class Token
        {
            public string? access_token { get; set; }
        }
    }
}
