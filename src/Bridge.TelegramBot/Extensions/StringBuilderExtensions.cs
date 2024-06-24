namespace Bridge.TelegramBot.Extensions;

public static class StringBuilderExtensions
{
    public static StringBuilder AppendSubstring(this StringBuilder stringBuilder, string? value, int max, string? prefix = null, string? defaultValue = null) =>
        stringBuilder.Substring(value, max, false, prefix, defaultValue);

    public static StringBuilder AppendLineSubstring(this StringBuilder stringBuilder, string? value, int max, string? prefix = null, string? defaultValue = null) =>
        stringBuilder.Substring(value, max, true, prefix, defaultValue);

    public static StringBuilder Substring(this StringBuilder stringBuilder, string? value, int max, bool line, string? prefix = null, string? defaultValue = null)
    {
        if (value != null || defaultValue != null)
        {
            stringBuilder
                .Append(prefix)
                .Append(Fix(value ?? defaultValue!, max));

            if (line)
                stringBuilder.AppendLine();
        }

        return stringBuilder;
    }

    private static string Fix(string value, int max) => value.Length > max ? $"{value[..(max - 3)]}..." : value;
}
