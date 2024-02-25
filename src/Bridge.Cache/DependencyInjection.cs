namespace Bridge.Cache;

public static class DependencyInjection
{
    public static IServiceControlBuilder AddCache(this IServiceControlBuilder builder) 
        => builder.AddService<ICache, Services.Cache, RedisOptions>(options => options.Name = "Redis");
}
