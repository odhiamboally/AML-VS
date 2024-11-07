namespace Aml.Shared.Messaging.RabbitMQ;

public interface IMessageProducer
{
    Task ProduceAsync<T>(T message);
}
