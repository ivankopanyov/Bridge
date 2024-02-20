namespace Bridge.Fias.Interface;

public static class DependencyInjection
{
    public static IServiceCollection AddFias(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IFiasService, FiasService>();
        serviceCollection.AddHostedService<FiasSocketClient>();

        return serviceCollection;
    }
}