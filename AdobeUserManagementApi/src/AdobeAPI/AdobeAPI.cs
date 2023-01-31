using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.AdobeAPI
{
    public class AdobeAPI
    {
        public HttpClient HttpClient { get; }
        public AdobeAPI(HttpClient httpClient) 
        {
            HttpClient = httpClient;
        }


    }
}
