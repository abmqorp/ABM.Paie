namespace ABM.Paie.Extensions;

public static class ObjectExtensions
{
    public static string? ToCss(this object obj)
    {
        return obj.ToString()?.ToLower();
    }
}
