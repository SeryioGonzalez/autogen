using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.AutoGen.Agents.Abstractions;

namespace Microsoft.AutoGen.Agents.Base;

public interface IAgentContext
{
    AgentId AgentId { get; }
    AgentBase? AgentInstance { get; set; }
    DistributedContextPropagator DistributedContextPropagator { get; }
    ILogger Logger { get; }
    ValueTask SendResponseAsync(RpcRequest request, RpcResponse response);
    ValueTask SendRequestAsync(AgentBase agent, RpcRequest request);
    ValueTask PublishEventAsync(CloudEvent @event);
}
