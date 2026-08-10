using static Common.Graphics.Models.Property;

namespace Common.Graphics.Svg.Models;

/// <summary>
/// The line element takes the positions of two points as parameters and draws a straight line between them.
/// </summary>
public sealed class Line(X1 x1, X2 x2, Y1 y1, Y2 y2) : Shape()
{
    public override Type Type => typeof(Components.Line);
    public override Dictionary<string, object> Attributes => GetAttributes(x1, x2, y1, y2);
}
