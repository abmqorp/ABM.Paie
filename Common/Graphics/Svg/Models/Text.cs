using static Common.Graphics.Models.Property;

namespace Common.Graphics.Svg.Models;

public sealed class Text(string content, X x, Y y) : Shape()
{
    public string Content { get; set; } = content;
    public override X? X { get; set; } = x;
    public override Y? Y { get; set; } = y;

    public override Type Type => typeof(Components.Text);
}
