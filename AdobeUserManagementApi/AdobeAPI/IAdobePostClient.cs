using AdobeUserManagementApi.Models;

namespace AdobeUserManagementApi.AdobeAPI
{
    public interface IAdobePostClient
    {
        Task<AdobePostResponse> AdobeTryPostAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken);
    }
}