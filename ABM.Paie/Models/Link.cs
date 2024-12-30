using ABM.Paie.Resources;

namespace ABM.Paie.Models;

public class Link(string? href = null, string? text = null, bool blank = false, string? css = null)
{
    public string? Text { get; } = text;
    public string? Href { get; } = href;
    public bool Blank { get; } = blank;
    public string? Target => Blank ? Constants.Blank : null;
    public string? Css { get; } = css;
}
