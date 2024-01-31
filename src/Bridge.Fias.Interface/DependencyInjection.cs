namespace Bridge.Fias.Interface;

public static class DependencyInjection
{
    public static IServiceCollection AddFias(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.ConfigureWritable<FiasOptions>(configuration.GetSection(FiasOptions.SectionName));
        serviceCollection.AddSingleton<IFiasService, FiasService>();
        serviceCollection.AddHostedService<FiasSocketClient>();

        return serviceCollection;
    }
}