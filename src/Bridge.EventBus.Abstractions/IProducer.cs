namespace Bridge.EventBus.Abstractions;

public interface IProducer
{
    void Publish<T>(T message, bool autoQueue = false);

    void Publish<T>(string queueName, T message, bool autoQueue = false);
}