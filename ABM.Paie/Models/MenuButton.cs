using ABM.Paie.Resources;

namespace ABM.Paie.Models;

public class MenuButton(string text, string? href = null, bool blank = false)
{
    public string Text { get; } = text;
    public string? Href { get; } = href;
    public bool Blank { get; } = blank;
    public string? Target => Blank ? Resources.Constants.Blank : null;
}
