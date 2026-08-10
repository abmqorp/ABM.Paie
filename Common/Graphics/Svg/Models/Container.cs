using Common.Graphics.Models;
using static Common.Graphics.Models.Property;

namespace Common.Graphics.Svg.Models;

public sealed class Container(ViewBox? viewBox, bool hasXmlns = false) : Builder
{
    private sealed class Xlmns : Property
    {
        public override string ToString() => "http://www.w3.org/2000/svg";
    }

    private Property? Xmlns => hasXmlns ? new Container.Xlmns() : null;

    public override Type Type => typeof(Components.Container);
    public override Dictionary<string, object> Attributes => GetAttributes(Xmlns, viewBox);
}
