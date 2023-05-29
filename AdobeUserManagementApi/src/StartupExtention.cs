using AdobeUserManagementApi.src.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src
{
    public static class ExtendStartup
    {
        public static AdobeTokenSettings SetAdobeTokenSettings(this AdobeTokenSettings adobeTokenSettings)
        {
            if (adobeTokenSettings.ClientSecret == null)
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


            return adobeTokenSettings;
        }
    }
}
