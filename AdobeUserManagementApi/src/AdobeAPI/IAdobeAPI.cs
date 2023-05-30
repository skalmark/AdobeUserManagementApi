using AdobeUserManagementApi.src.Models;

namespace AdobeUserManagementApi.src.AdobeAPI
{
    public interface IAdobeAPI
    { 
        Task<T> GetAdobeDataAsync<T>(string url, CancellationToken cancellationtoken);
        Task<AdobePostResponse> PostAdobeAsync(HttpContent content, CancellationToken cancellationtoken);
        Task<AdobePostResponse?> TestPostAdobeAsync(HttpContent content, CancellationToken cancellationtoken);
    }
}