namespace Bridge.Cache;

/// <summary>Модель опций сервиса кеширования данных.</summary>
public interface ICacheOptions
{
    /// <summary>Время жизни сервиса.</summary>
    ServiceLifetime Lifetime { get; }
}
