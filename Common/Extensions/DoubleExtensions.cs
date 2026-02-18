using System.Globalization;

namespace Common.Extensions;

public static class DoubleExtensions
{
    extension(double value)
    {
        public string Invariant => value.ToString(CultureInfo.InvariantCulture);
    }

    extension(double? value)
    {
        public string Invariant => value?.Invariant ?? "";
    }
}
