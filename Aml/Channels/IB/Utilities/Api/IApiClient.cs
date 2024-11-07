using Aml.Channels.IB.Features.Rules.Contracts;
using Refit;

namespace Aml.Channels.IB.Utilities.Api;

public interface IApiClient
{
    [Post("/api/rule/create")]
    Task<RuleResponse> FetchAccountData([Body] CreateRuleRequest createRuleRequest);
}
