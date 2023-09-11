using AdobeUserManagementApi.Models;

namespace AdobeUserManagementApi.AdobeAPI.InterFaces
{
    public interface IAdobePostClient
    {
        Task<AdobePostResponse> AdobeTryPostAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken);
    }
}