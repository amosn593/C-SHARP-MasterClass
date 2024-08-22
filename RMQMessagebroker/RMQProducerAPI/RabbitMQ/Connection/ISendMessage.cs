namespace RMQProducerAPI.RabbitMQ.Connection;

public interface ISendMessage
{
    void PublishOrder<T>(T message);
}
