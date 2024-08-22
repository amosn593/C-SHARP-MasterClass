using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RMQProducerAPI.RabbitMQ.Connection;

public class SendMessage : ISendMessage
{
    private readonly IRabbitMqConnection _connection;
    public SendMessage(IRabbitMqConnection connection)
    {
        _connection = connection;
    }
    public void PublishOrder<T>(T message)
    {
        using var channel = _connection.Connection.CreateModel();

        channel.QueueDeclare("orders");

        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);

        channel.BasicPublish(exchange: "", routingKey: "orders", body: body);
    }
}
