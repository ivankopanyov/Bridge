namespace Bridge.Fias.Interface;

public static class FiasDependencyInjection
{
    public static IServiceCollection AddFias(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IFiasService, FiasService>();
        serviceCollection.AddHostedService<FiasSocketClient>();

        return serviceCollection;
    }
}