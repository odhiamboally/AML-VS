using MassTransit;

namespace Aml.Shared.Messaging.RabbitMQ;

internal sealed class RabbitMqBusMessageProducer : IMessageProducer
{
    private readonly IBus _bus;
    public RabbitMqBusMessageProducer(IBus bus)
    {
        _bus = bus;
    }

    public async Task ProduceAsync<T>(T message)
    {
        await _bus.Publish(message!);

        // Sending to a specific queue
        var endpoint = await _bus.GetSendEndpoint(new Uri("rabbitmq://localhost/some-queue"));
        await endpoint.Send(message!);
    }
}
