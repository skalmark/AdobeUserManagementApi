using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.Requests.Serilizer
{
    internal static class ConverToJson
    {
        internal static string ConvertToJson<T>(T @object)
        {
            return JsonSerializer.Serialize(new[] { @object });
        }
    }
}
