using static Common.Graphics.Models.Property;

namespace Common.Graphics.Svg.Models;

/// <summary>
/// The circle element draws a circle on the screen.
/// </summary>
/// <param name="cx">The x position of the center of the circle.</param>
/// <param name="cy">The y position of the center of the circle.</param>
/// <param name="r">The radius of the circle.</param>
public sealed class Circle(Cx cx, Cy cy, R r) : Shape
{
    public override Type Type => typeof(Components.Circle);
    public override Dictionary<string, object> Attributes => GetAttributes(cx, cy, r);
}
