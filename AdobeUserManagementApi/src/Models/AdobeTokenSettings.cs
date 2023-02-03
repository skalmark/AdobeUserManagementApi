using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Models
{
    public class AdobeTokenSettings
    {
        public string Clientid { get; set; }
        public string ClientSecret { get; set; }
        public string OrgID { get; set; }
        public string TechAccountID { get; set; }
        public X509Certificate2 AdobeCertificate { get; set; }  
    }
}
