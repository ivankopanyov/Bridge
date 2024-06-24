namespace Bridge.EventBus;

public class TaskCriticalException(string? message, Exception? innerException) : Exception(message, innerException)
{
}
