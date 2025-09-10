namespace Common.Models;
public record UriModel(string Label, string Uri, string? Content = null, bool IsExternal = false, string? Image = null)
{
    public override string ToString() => Uri;
}
