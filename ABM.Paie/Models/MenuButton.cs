using Microsoft.AspNetCore.Components;

namespace ABM.Paie.Models;

public class MenuButton(string text, string? href = null, bool blank = false)
{
    public MarkupString Text { get; } = (MarkupString)text;
    public string? Href { get; } = href;
    public bool Blank { get; } = blank;
    public string? Target => Blank ? "_blank" : null;
}
