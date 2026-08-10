using Common.Graphics.Svg.Enumerations;
using Common.Graphics.Svg.Extensions;
using static Common.Graphics.Models.Property;

namespace Common.Graphics.Svg.Models;

public sealed class Path : Shape
{
    public D D { get; }

    public override Type Type => typeof(Components.Path);
    public override Dictionary<string, object> Attributes => GetAttributes(D);

    public Path(D d) => D = d;

    public Path(Icon icon) => D = icon.Path;
}
