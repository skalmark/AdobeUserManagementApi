using AdobeUserManagementApi.Models;

namespace AdobeUserManagementApi.AdobeAPI.InterFaces
{
    public interface IAdobeAPIClient
    {
        Task<T> CallAdobeUserManagementAPI<T>(HttpRequestMessage httpRequestMessage, CancellationToken cancellationtoken);
    }
}