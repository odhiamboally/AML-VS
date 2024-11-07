using Refit;

namespace Aml.Shared.Configurations.Api;

internal sealed class ApiClientFactory<T> : IApiClientFactory<T>
{
    private readonly RefitSettings _refitSettings;

    public ApiClientFactory(RefitSettings refitSettings)
    {
        _refitSettings = refitSettings;

    }

    public T CreateClient(string nodeBaseUrl)
    {
        if (string.IsNullOrWhiteSpace(nodeBaseUrl))
        {
            throw new ArgumentException("Bank base URL cannot be null or empty", nameof(nodeBaseUrl));
        }

        // Create and configure an HttpClient with timeout, etc.
        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(nodeBaseUrl),
            Timeout = TimeSpan.FromSeconds(500),  // You can adjust the timeout as necessary

        };

        // Create and return a Refit client dynamically
        return RestService.For<T>(httpClient, _refitSettings);
    }
}
