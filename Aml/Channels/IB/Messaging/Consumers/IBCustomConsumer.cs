using Aml.Channels.IB.Messaging.Messages;
using MassTransit;

namespace Aml.Channels.IB.Messaging.Consumers;


internal sealed class IBCustomConsumer : IConsumer<IBRuleMessage>
{
    public async Task Consume(ConsumeContext<IBRuleMessage> context)
    {
        // Handle the incoming message
        var message = context.Message;

        // Add Custom business logic here
        await Task.CompletedTask;
    }
}
