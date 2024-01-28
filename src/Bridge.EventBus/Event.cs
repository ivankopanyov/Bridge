namespace Bridge.EventBus;

internal class Event<T> where T : class, new()
{
    public string? QueueName { get; set; }

    public string? TaskId { get; set; }

    public T? Message { get; set; }
}
