namespace Bridge.EventBus.RabbitMq;

internal class RabbitMqProducer(RabbitMqOptions options, ILogger? logger = null) : RabbitMqBase(options), IProducer
{
    private readonly Lazy<Queue<string>> _queue = new(() => []);

    private readonly object _lock = new();

    public void Publish<T>(T message, bool autoQueue = false)
    {
        ArgumentNullException.ThrowIfNull(message, nameof(message));

        Publish(message, GetName<T>(), autoQueue);
    }

    public void Publish<T>(string queueName, T message, bool autoQueue = false)
    {
        ArgumentNullException.ThrowIfNull(queueName, nameof(queueName));
        ArgumentNullException.ThrowIfNull(message, nameof(message));

        Publish(message, GetName<T>(queueName), autoQueue);
    }

    private void Publish<T>(T message, string exchangeName, bool autoQueue)
    {
        string body;

        try
        {
            body = JsonConvert.SerializeObject(message, JsonSerializerSettings);
            if (body == null)
            {
                logger?.LogWarning(SERVICE_NAME, "Failed to serialize message.");
                return;
            }
        }
        catch (Exception ex)
        {
            logger?.LogWarning(SERVICE_NAME, ex.Message, ex);
            return;
        }

        var queue = _queue.Value;

        lock (_lock)
        {
            if (queue.Count == 0)
            {
                if (!Publish(exchangeName, body, true, autoQueue))
                {
                    queue.Enqueue(body);
                    new Thread(() =>
                    {
                        while (queue.Count > 0)
                        {
                            lock (_lock)
                            {
                                if (Publish(exchangeName, queue.Peek(), false, autoQueue))
                                    queue.Dequeue();
                            }
                        }
                    }).Start();
                }
            }
            else
                queue.Enqueue(body);
        }
    }

    private bool Publish(string exchangeName, string message, bool log, bool autoQueue)
    {
        try
        {
            byte[] body;
            try
            {
                body = Encoding.UTF8.GetBytes(message);
            }
            catch (Exception ex)
            {
                logger?.LogWarning(SERVICE_NAME, ex.Message, ex);
                message = string.Empty;
                body = Array.Empty<byte>();
            }

            using var connection = NewConnection;
            using var channel = connection.CreateModel();
            channel.ExchangeDeclare(exchangeName, ExchangeType.Direct);
            if (autoQueue)
            {
                channel.QueueDeclare(queue: exchangeName, durable: true, exclusive: false, autoDelete: false);
                channel.QueueBind(exchangeName, exchangeName, string.Empty);
            }
            channel.BasicPublish(exchange: exchangeName, routingKey: string.Empty, body: body);
            return true;
        }
        catch (Exception ex)
        {
            if (log)
                logger?.LogUnactive(SERVICE_NAME, ex.Message, ex);

            return false;
        }
    }
}