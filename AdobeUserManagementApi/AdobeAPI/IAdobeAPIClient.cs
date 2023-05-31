using AdobeUserManagementApi.Models;

namespace AdobeUserManagementApi.AdobeAPI
{
    public interface IAdobeAPIClient
    {
        Task<T> CallAdobeUserManagementAPI<T>(HttpRequestMessage httpRequestMessage, CancellationToken cancellationtoken);
    }
}