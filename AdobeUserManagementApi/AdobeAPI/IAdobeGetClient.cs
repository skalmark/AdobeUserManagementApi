namespace AdobeUserManagementApi.AdobeAPI
{
    public interface IAdobeGetClient
    {
        Task<T> AdobeTryGetAsync<T>(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken);
    }
}