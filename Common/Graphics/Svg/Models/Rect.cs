using static Common.Graphics.Models.Property;

namespace Common.Graphics.Svg.Models;

/// <summary>
/// The rect element draws a rectangle on the screen.
/// <list type="bullet">
/// <item><see cref="Rx"/> is the x radius of the corners of the rectangle.</item>
/// <item><see cref="Ry"/> is the y radius of the corners of the rectangle.</item>
/// </list>
/// </summary>
/// <param name="x">The x position of the top left corner of the rectangle.</param>
/// <param name="y">The y position of the top left corner of the rectangle.</param>
/// <param name="width">The width of the rectangle.</param>
/// <param name="height">The height of the rectangle.</param>
public sealed class Rect(
    X x,
    Y y,
    Width width,
    Height height)
    : Shape()
{
    public override X? X { get; set; } = x;
    public override Y? Y { get; set; } = y;
    public override Width? Width { get; set; } = width;
    public override Height? Height { get; set; } = height;
    public Rx? Rx { get; set; }
    public Ry? Ry { get; set; }

    public override Type Type => typeof(Components.Rect);
    public override Dictionary<string, object> Attributes => GetAttributes(Rx, Ry);
}
