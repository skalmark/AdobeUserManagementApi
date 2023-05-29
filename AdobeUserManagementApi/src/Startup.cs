using AdobeUserManagementApi.src.AdobeAPI;
using AdobeUserManagementApi.src.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;


namespace AdobeUserManagementApi
{
    public static class Startup
    {
        public static IServiceCollection AddAdobeManagmentAPI([NotNull] this IServiceCollection services)
        {


            return services;
        }

        public static IServiceCollection AddAdobeManagmentAPI([NotNull] this IServiceCollection services, [NotNull] AdobeTokenSettings adobeTokenSettings)
        {
            if (adobeTokenSettings.ClientSecret is null)
            {
                throw new ArgumentNullException("ClientSecret");
            }

            if (adobeTokenSettings.Clientid == null)
            {
                throw new ArgumentNullException("configuration");
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

            services.AddHttpClient<AdobeAPI>(HttpClient =>
            {
                HttpClient.BaseAddress = new Uri("https://usermanagement.adobe.io");
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpClient.DefaultRequestHeaders.Add("X-Api-Key", adobeTokenSettings.Clientid);
            });

            return services;
        }

        public static IServiceCollection AddAdobeManagmentAPI(this IServiceCollection services, string adobeOrgID, string adobeClientID)
        {
            services.AddHttpClient<AdobeAPI>(HttpClient =>
            {
                HttpClient.BaseAddress = new Uri("https://usermanagement.adobe.io");
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpClient.DefaultRequestHeaders.Add("X-Api-Key", adobeClientID);
            });

            return services;
        }


    }
}
