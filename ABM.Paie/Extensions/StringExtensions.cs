using Microsoft.AspNetCore.Components;

namespace ABM.Paie.Extensions;

public static class StringExtensions
{
    public static string ToBold(this string str)
    {
        return $"<b>{str}</b>";
    }

    public static string ToItalic(this string str)
    {
        return $"<i>{str}</i>";
    }

    public static MarkupString ToMarkup(this string str)
    {
        return new MarkupString(str);
    }
}
