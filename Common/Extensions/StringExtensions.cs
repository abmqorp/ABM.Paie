namespace Common.Extensions;
public static class StringExtensions
{
    public static string UpFirstChar(this string value)
        => string.IsNullOrWhiteSpace(value)
            ? string.Empty
            : string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
}
