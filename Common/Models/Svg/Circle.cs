using Common.Extensions;

namespace Common.Models.Svg;

/// <summary>
/// The circle element draws a circle on the screen.
/// </summary>
/// <param name="Cx">The x position of the center of the circle.</param>
/// <param name="Cy">The y position of the center of the circle.</param>
/// <param name="R">The radius of the circle.</param>
public sealed record Circle(double Cx, double Cy, double R, Palette Palette, bool IsFocusable = default, bool IsSelected = default)
    : Shape(Palette, IsFocusable, IsSelected)
{
    public override IEnumerable<KeyValuePair<string, object>> Attributes => [
        new(nameof(Cx).ToLower(), Cx.Invariant),
        new(nameof(Cy).ToLower(), Cy.Invariant),
        new(nameof(R).ToLower(), R.Invariant),
    ];
}
