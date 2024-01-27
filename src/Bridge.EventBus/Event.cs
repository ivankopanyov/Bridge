namespace Bridge.EventBus;

internal class Event<T> where T : Message
{
    public string? QueueName { get; set; }

    public string? TaskId { get; set; }

    public T? Message { get; set; }
}
