using AdobeUserManagementApi.src.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi
{
    public static class StartupExtention
    {
        public static IGlobalConfiguration<AdobeTokenSettings> SetAdobeTokenSettings([NotNull] this IGlobalConfiguration configuration,
            [NotNull] string _clientid,
            [NotNull] string _clientSecret,
            [NotNull] string _orgID,
            [NotNull] string _techAccountID,
            [NotNull]X509Certificate2 AdobeCertificate)
        {
            if (_clientSecret == null)
            {
                throw new ArgumentNullException("configuration");
            }

            if (_orgID == null)
            {
                throw new ArgumentNullException("nameOrConnectionString");
            }

            if (_orgID == null)
            {
                throw new ArgumentNullException("nameOrConnectionString");
            }

            if (_techAccountID == null)
            {
                throw new ArgumentNullException("nameOrConnectionString");
            }

            if (AdobeCertificate == null)
            {
                throw new ArgumentNullException("AdobeCertificate");
            }

            AdobeTokenSettings storage = new AdobeTokenSettings
                {
                Clientid = _clientid,
                ClientSecret = _clientSecret,
                OrgID= _orgID,
                TechAccountID= _techAccountID,
                AdobeCertificate= AdobeCertificate
            };
            return  configuration.SetAdobeTokenSettings(storage);
        }
    }
}
