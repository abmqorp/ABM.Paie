using Common.Extensions;

namespace Common.Models.Svg;

/// <summary>
/// The rect element draws a rectangle on the screen.
/// </summary>
/// <param name="X">The x position of the top left corner of the rectangle.</param>
/// <param name="Y">The y position of the top left corner of the rectangle.</param>
/// <param name="Width">The width of the rectangle.</param>
/// <param name="Height">The height of the rectangle.</param>
/// <param name="Rx">The x radius of the corners of the rectangle.</param>
/// <param name="Ry">The y radius of the corners of the rectangle.</param>
public sealed record Rect(
    double X,
    double Y,
    double Width,
    double Height,
    Palette Palette,
    bool IsFocusable = default,
    bool IsSelected = default,
    double Rx = 0,
    double Ry = 0)
    : Shape(Palette, IsFocusable, IsSelected)
{
    public override IEnumerable<KeyValuePair<string, object>> Attributes => [
        new(nameof(X).ToLower(), X.Invariant),
        new(nameof(Y).ToLower(), Y.Invariant),
        new(nameof(Width).ToLower(), Width.Invariant),
        new(nameof(Height).ToLower(), Height.Invariant),
        new(nameof(Rx).ToLower(), Rx.Invariant),
        new(nameof(Ry).ToLower(), Ry.Invariant),
    ];
}
