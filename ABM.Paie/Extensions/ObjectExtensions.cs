namespace ABM.Paie.Extensions;

public static class ObjectExtensions
{
    public static string? ToCss(this object obj) => obj.ToString()?.ToLower().Trim();
}
