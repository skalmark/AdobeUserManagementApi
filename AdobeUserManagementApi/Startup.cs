using AdobeUserManagementApi.AdobeAPI;
using AdobeUserManagementApi.Options;
using Microsoft.Extensions.DependencyInjection;
using Polly;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;


namespace AdobeUserManagementApi
{
    public static class Startup
    {
        //https://adobe-apiplatform.github.io/umapi-documentation/en/api/ActionsRef.html
        public static IServiceCollection AddAdobeManagmentAPI([NotNull] this IServiceCollection services, [NotNull] AdobeAPISettings adobeTokenSettings)
        {
            if (adobeTokenSettings.ClientSecret is null)
            {
                throw new ArgumentNullException("ClientSecret");
            }

            if (adobeTokenSettings.Clientid == null)
            {
                throw new ArgumentNullException("Clientid");
            }

            if (adobeTokenSettings.OrgID == null)
            {
                throw new ArgumentNullException("nameOrConnectionString");
            }

            if (adobeTokenSettings.ClientSecret == null)
            {
                throw new ArgumentNullException("nameOrConnectionString");
            }

            if (adobeTokenSettings.TechAccountID == null)
            {
                throw new ArgumentNullException("nameOrConnectionString");
            }

            services.Configure<AdobeAPISettings>(options =>
            {
                options.Clientid = adobeTokenSettings.Clientid;
                options.ClientSecret = adobeTokenSettings.ClientSecret;
                options.TechAccountID = adobeTokenSettings.TechAccountID;
                options.OrgID = adobeTokenSettings.OrgID;
                options.OauthToken = string.Empty;
                options.TokenLifeTime = null;

            });

            services.AddHttpClient<AdobeToken>();

            services.AddHttpClient<AdobeAPIClient>(HttpClient =>
            {
                HttpClient.BaseAddress = new Uri("https://usermanagement.adobe.io");
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpClient.DefaultRequestHeaders.Add("X-Api-Key", adobeTokenSettings.Clientid);
            });
            services.AddSingleton<IAdobeGetClient, AdobeGetClient>(provider =>
            new AdobeGetClient(provider.GetService<AdobeAPIClient>(), 25));

            services.AddSingleton<IAdobePostClient, AdobePostClient>(provider =>
            new AdobePostClient(provider.GetService<AdobeAPIClient>(), 10));


            return services;
        }


    }
}
