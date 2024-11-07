namespace Aml.Shared.Messaging.RabbitMQ;

public interface IMessageConsumer
{
    Task ConsumeAsync<T>(Func<T, Task> handler) where T : class;
}
