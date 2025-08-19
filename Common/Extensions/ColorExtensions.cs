using Common.Enumerations;

namespace Common.Extensions;
public static class ColorExtensions
{
    public static string ToVar(this Color value) => $"var({value.GetDescription()})";
}
