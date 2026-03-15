using Common.Extensions;
using Common.Models.General;

namespace Common.Models.Svg;

/// <summary>
/// The line element takes the positions of two points as parameters and draws a straight line between them.
/// </summary>
public sealed record Line(Vector Start, Vector End, Palette Palette) : Shape(Palette)
{
    public override IEnumerable<KeyValuePair<string, object>> Attributes => [
        new(nameof(X1).ToLower(), X1.Invariant),
        new(nameof(X2).ToLower(), X2.Invariant),
        new(nameof(Y1).ToLower(), Y1.Invariant),
        new(nameof(Y2).ToLower(), Y2.Invariant),
    ];

    private double X1 => Start.X;
    private double X2 => End.X;
    private double Y1 => Start.Y;
    private double Y2 => End.Y;
}
