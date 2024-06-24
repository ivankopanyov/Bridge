namespace Bridge.EventBus.Converters;

internal class DateTimeConverter : IsoDateTimeConverter
{
    public DateTimeConverter() => DateTimeFormat = "yyyy-MM-ddTHH:mm:ss.fffzzz";
}
