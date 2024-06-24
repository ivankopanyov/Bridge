namespace Bridge.Cache;

/// <summary>Сервис кеширования данных.</summary>
public interface ICacheService
{
    /// <summary>Метод возвращает из кеша все объекты указанного типа.</summary>
    /// <typeparam name="T">Тип возвращаемых объектов.</typeparam>
    /// <returns>Все сохранненые объекты указанного типа.</returns>
    Task<IEnumerable<T>> GetAllAsync<T>() where T : class;

    /// <summary>Метод возвращает из кеша объект указанного типа с указанным ключем.</summary>
    /// <typeparam name="T">Тип возвращаемого объекта.</typeparam>
    /// <param name="key">Ключ возвращаемого объекта.</param>
    /// <returns>
    /// Сохраненный объект указанного типа с указанным ключем.<br/>
    /// Если объект не найден, возвращает <b>null</b>.
    /// </returns>
    Task<T?> GetAsync<T>(string key) where T : class;

    Task PushAsync<T>(string key, T value, TimeSpan? expiry = null) where T : class;

    /// <summary>Метод возвращает и удаляет из кеша объект указанного типа с указанным ключем.</summary>
    /// <typeparam name="T">Тип возвращаемого объекта.</typeparam>
    /// <param name="key">Ключ возвращаемого объекта.</param>
    /// <returns>
    /// Сохраненный объект указанного типа с указанным ключем.<br/>
    /// Если объект не найден, возвращает <b>null</b>.
    /// </returns>
    Task<T?> PopAsync<T>(string key) where T : class;

    /// <summary>Метод проверяет наличие в кеше объекта указанного типа с указанным ключем.</summary>
    /// <typeparam name="T">Тип проверяемого объекта.</typeparam>
    /// <param name="key">Ключ проверяемого объекта.</param>
    /// <returns>
    /// <b>True</b> - если объект найден в базе.<br/>
    /// <b>False</b> - если объект не найден в базе.
    /// </returns>
    Task<bool> ExistsAsync<T>(string key) where T : class;
}
