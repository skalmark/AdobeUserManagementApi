using AdobeUserManagementApi.src.Models;

namespace AdobeUserManagementApi.src.AdobeAPI
{
    public interface IAdobeAPI
    { 
        Task<T> CallAdobeUserManagementAPI<T>(HttpRequestMessage httpRequestMessage, CancellationToken cancellationtoken);
    }
}