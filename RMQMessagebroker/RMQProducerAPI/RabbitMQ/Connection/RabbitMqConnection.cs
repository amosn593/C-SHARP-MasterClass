using RabbitMQ.Client;

namespace RMQProducerAPI.RabbitMQ.Connection;

public class RabbitMqConnection : IRabbitMqConnection, IDisposable
{
    private IConnection? _connection;
    public IConnection Connection => _connection!;
    public RabbitMqConnection()
    {
        InitilizeConnection();
    }
    
    private void InitilizeConnection()
    {
        var factory = new ConnectionFactory { HostName = "localhost" };

        _connection = factory.CreateConnection();
    }

    public void Dispose()
    {
        _connection?.Dispose();
    }
}
