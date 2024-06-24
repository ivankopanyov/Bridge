namespace Bridge.EventBus.Extensions;

internal static class DateTimeExtensions
{
    public static DateTime Trim(this DateTime date, long ticks) => new(date.Ticks - (date.Ticks % ticks), date.Kind);
}
