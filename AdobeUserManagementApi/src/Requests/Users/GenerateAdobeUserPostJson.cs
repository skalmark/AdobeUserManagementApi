using AdobeUserManagementApi.src.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdobeUserManagementApi.src.Requests.Users
{
    public static class GenerateAdobeUserPostJson<T> where T : class
    {
        public static string GenerateAdobeUserPostJsonData(string emailAddress, T data)
        {
            AdobeUserRequest<T> adobePostData = new()
            {
                User = emailAddress,
                RequestID = $"{DateTimeOffset.Now:yyyy-MM-dd}_{emailAddress}",
                Do = new List<T>()
                {
                    data
                }
            };

            return JsonSerializer.Serialize(new[] { adobePostData });
        }
    }
}
