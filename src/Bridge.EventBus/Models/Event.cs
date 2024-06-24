namespace Bridge.EventBus;

public class Event
{
    [JsonProperty]
    internal string Id { get; set; }

    [JsonProperty]
    internal string TaskId { get; set; }

    [JsonProperty]
    internal string? TaskName { get; set; }

    [JsonProperty]
    internal string? Error { get; set; }

    [JsonProperty]
    internal string? StackTrace { get; set; }

    internal Event() { }

    internal virtual void Publish(IProducer producer) => producer.Publish(this);

    internal virtual void Publish(IProducer producer, string queueName) => producer.Publish(queueName, this);
}

public class Event<T> : Event
{
    [JsonProperty]
    internal T Message { get; set; }

    internal Event() { }

    internal override void Publish(IProducer producer) => producer.Publish(this);

    internal override void Publish(IProducer producer, string queueName) => producer.Publish(queueName, this);
}