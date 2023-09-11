using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Options
{
    public sealed class AdobeAPISettings
    {
        public string Clientid { get; set; }
        public string ClientSecret { get; set; }
        public string OrgID { get; set; }
        public string TechAccountID { get; set; }
        public string OauthToken { get; set; }
        public DateTimeOffset? TokenLifeTime { get; set; }
    }
}
