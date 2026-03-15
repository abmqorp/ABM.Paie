namespace Common.Models.Svg;

public sealed record Path(
    string D,
    Palette Palette,
    bool IsFocusable = default,
    bool IsSelected = default)
    : Shape(Palette, IsFocusable, IsSelected)
{
    public override IEnumerable<KeyValuePair<string, object>> Attributes => [new(nameof(D).ToLower(), D)];
}
