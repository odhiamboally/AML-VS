namespace Aml.Shared.Configurations.Api;

internal interface IApiClientFactory<T>
{
    T CreateClient(string nodeBaseUrl);

}