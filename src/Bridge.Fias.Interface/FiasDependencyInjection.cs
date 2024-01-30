namespace Bridge.Fias.Interface;

public static class FiasDependencyInjection
{
    public static IServiceCollection AddFias(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.ConfigureWritable<FiasOptions>(configuration.GetSection(FiasOptions.SectionName));
        serviceCollection.AddSingleton<IFiasService, FiasService>();
        serviceCollection.AddHostedService<FiasSocketClient>();

        return serviceCollection;
    }
}