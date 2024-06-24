namespace Bridge.Cache;

/// <summary>Абстрактный класс, описывающий базовый сервис кеширования</summary>
/// <typeparam name="TOptions">
/// Тип объекта опций сервиса.<br/>
/// Класс, содержащий публичный конструктор без параметров.
/// </typeparam>
public abstract class CacheServiceBase<TOptions> where TOptions : class, new()
{
}
