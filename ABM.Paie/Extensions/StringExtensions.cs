namespace ABM.Paie.Extensions;

public static class StringExtensions
{
    public static string ToBold(this string value)
    {
        return $"<b>{value}</b>";
    }
}
