using Common.Extensions;

namespace Common.Models.Svg;

public sealed record Text(string Content, double X, double Y, Palette Palette) : Shape(Palette, false, Content: Content)
{
    public override IEnumerable<KeyValuePair<string, object>> Attributes => [
        new(nameof(X).ToLower(), X.Invariant),
        new(nameof(Y).ToLower(), Y.Invariant),
    ];
}
