using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFiles.Client
{
    internal class AzureFilesHttpClient
    {
        const string authHeader = "SharedKey stprodwedatasrcfiles01: AsWB5z/WMp52hPed5hg7TUlKNG7UXBnXaIZfO3luNT9EZ2YbipT26w2FO3QxrFxhd/1ZEh/yfnEN+AStLFb/AQ==";

        private readonly HttpClient _httpClient;
        internal AzureFilesHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://stprodwedatasrcfiles01.privatelink.file.core.windows.net");


            _httpClient = httpClient;
        }

    }
}
