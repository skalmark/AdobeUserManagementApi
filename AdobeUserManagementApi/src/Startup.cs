using AdobeUserManagementApi.src.AdobeAPI;
using AdobeUserManagementApi.src.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi
{
    public static class Startup
    {
        public static IServiceCollection AddAdobeManagmentAPI([NotNull] this IServiceCollection services)
        {


            return services;
        }

        public static IServiceCollection AddAdobeManagmentAPI([NotNull] this IServiceCollection services, [NotNull] Func<AdobeTokenSettings> configuration)
        {
            //services.Configure(configuration);
            services.AddHttpClient<AdobeAPI>(HttpClient =>
            {
                HttpClient.BaseAddress = new Uri("https://usermanagement.adobe.io");
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //HttpClient.DefaultRequestHeaders.Add("X-Api-Key", );
            });

            return services;
        }

        public static IServiceCollection AddAdobeManagmentAPI(this IServiceCollection services, string adobeOrgID, string adobeClientID, X509Certificate2 certificate)
        {
            services.AddHttpClient<AdobeAPI>(HttpClient =>
            {
                HttpClient.BaseAddress = new Uri("https://usermanagement.adobe.io");
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpClient.DefaultRequestHeaders.Add("X-Api-Key", adobeClientID);
            });

            return services;
        }

        private static IServiceCollection AddAdobeGetTokenservice(this IServiceCollection services, X509Certificate2 certificate)
        {
            services.AddHttpClient<AdobeAPI>(HttpClient =>
            {
                HttpClient.BaseAddress = new Uri("https://ims-na1.adobelogin.com/ims/exchange/jwt/");
                HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                X509Certificate2 cert = certificate;
            });

            return services;
        }
    }
}
