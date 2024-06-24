namespace Bridge.Cache;

/// <summary>Статический класс, содержащий методы расширения интерфейса <see cref="IServiceCollection"/></summary>
public static class DependencyInjection
{
    /// <summary>
    /// Метод, расширяющий интерфейс <see cref="IServiceCollection"/>.<br/>
    /// Регистрирует сервис кеширования в контейнере зависимостей.
    /// </summary>
    /// <typeparam name="TService">
    /// Тип класса сервиса кеширования.<br/>
    /// Должен быть производным классом от <see cref="CacheServiceBase{T}"/> и имплементировать интерфейс <see cref="ICacheService"/>
    /// </typeparam>
    /// <typeparam name="TOptions">
    /// Тип класса опций сервиса кеширования.<br/>
    /// Класс должен иметь публичный конструктор без параметров.
    /// </typeparam>
    /// <param name="services">Текущий объект <see cref="IServiceCollection"/>.</param>
    /// <param name="options">Делегат метода инициализации оциий сервиса кеширования.</param>
    /// <returns>Текущий объект <see cref="IServiceCollection"/>.</returns>
    public static IServiceCollection AddCache<TService, TOptions>(this IServiceCollection services, Action<TOptions>? options = null)
        where TService : CacheServiceBase<TOptions>, ICacheService where TOptions : class, ICacheOptions, new()
    {
        var cacheOptions = new TOptions();
        options?.Invoke(cacheOptions);
        services.AddSingleton(cacheOptions);

        return cacheOptions.Lifetime switch
        {
            ServiceLifetime.Transient => services.AddTransient<ICacheService, TService>(),
            ServiceLifetime.Singleton => services.AddSingleton<ICacheService, TService>(),
            _ => services.AddScoped<ICacheService, TService>(),
        };
    }
}
