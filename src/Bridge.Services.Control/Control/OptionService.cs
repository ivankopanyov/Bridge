namespace Bridge.Services.Control;

internal class OptionService<T>(T optionable) : BackgroundService where T : IOptinable
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken) 
        => await optionable.GetOptionsAsync();
}
