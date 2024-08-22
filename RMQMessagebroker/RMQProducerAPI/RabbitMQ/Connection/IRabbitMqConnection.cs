using RabbitMQ.Client;

namespace RMQProducerAPI.RabbitMQ.Connection;

public interface IRabbitMqConnection
{
    IConnection Connection { get; }
}
