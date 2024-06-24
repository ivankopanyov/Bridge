namespace Bridge.Services.Control.Services.Base;

internal abstract class StarterBase : BackgroundService
{
    private protected static string GetQueueName(string hostName, string serviceName) => $"{hostName}#{serviceName}";
}
