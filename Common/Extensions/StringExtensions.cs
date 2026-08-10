namespace Common.Extensions;

public static class StringExtensions
{
    extension(string value)
    {
        public string UpFirstChar() => string.IsNullOrWhiteSpace(value)
            ? string.Empty
            : string.Concat(value[0].ToString().ToUpper(), value.AsSpan(1));

        public string ToCamelCase()
        {
            var str = "";

            if (!string.IsNullOrWhiteSpace(value))
            {
                char[] _array = value.ToCharArray();
                _array[0] = char.ToLower(_array[0]);
                str = new string(_array);
            }

            return str;
        }
    }
}
