namespace Common.Extensions;

public static class StringExtensions
{
    extension(string value)
    {
        public string UpFirstChar() => string.IsNullOrWhiteSpace(value)
            ? string.Empty
            : string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));
    }
}
