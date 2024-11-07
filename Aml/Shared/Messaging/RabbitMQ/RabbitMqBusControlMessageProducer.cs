using MassTransit;

namespace Aml.Shared.Messaging.RabbitMQ;

internal sealed class RabbitMqBusControlMessageProducer : IMessageProducer
{
    private readonly IBusControl _busControl;
    public RabbitMqBusControlMessageProducer(IBusControl busControl)
    {
        _busControl = busControl;

    }

    public async Task ProduceAsync<T>(T message) 
    { 
        try
        {
            var endpoint = await _busControl.GetSendEndpoint(new Uri("rabbitmq://localhost/some-queue"));
            await endpoint.Send(message!);
        }
        finally
        {
            await _busControl.StopAsync();
        }

    }
}