using AdobeUserManagementApi.AdobeAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeUserManagementApi
{
    public class AdobeClient
    {
        private readonly IAdobeAPIClient _adobeAPIClient;

        public AdobeClient(IAdobeAPIClient adobeAPIClient)
        {
            _adobeAPIClient = adobeAPIClient;
        }

        public async Task GetAllUsers()
        {

        }
    }
}
