using Common.Graphics.Models;
using static Common.Graphics.Models.Property;

namespace Common.Graphics.Svg.Models;

public abstract class Shape
{
    public Fill? Fill { get; set; }
    public FontSize? FontSize { get; set; }
    public virtual Height? Height { get; set; }
    public Opacity? Opacity { get; set; }
    public Stroke? Stroke { get; set; }
    public StrokeLineCap? StrokeLineCap { get; set; }
    public TextAnchor? TextAnchor { get; set; }
    public Transform? Transform { get; set; }
    public virtual Width? Width { get; set; }
    public virtual X? X { get; set; }
    public virtual Y? Y { get; set; }

    public abstract Type Type { get; }
    public virtual Dictionary<string, object> Attributes => GetAttributes();

    protected Dictionary<string, object> GetAttributes(params Property?[] properties)
    {
        var attributes = new Dictionary<string, object>();

        SafeAddTo(attributes, properties);

        SafeAddTo(attributes,
            Fill,
            FontSize,
            Height,
            Opacity,
            Stroke,
            StrokeLineCap,
            TextAnchor,
            Transform,
            Width,
            X,
            Y);

        return attributes;
    }

    protected static void SafeAddTo(IDictionary<string, object> dictionary, params Property?[] properties)
    {
        foreach (var property in properties)
        {
            if (property?.ToAttribute() is KeyValuePair<string, object> attribute) dictionary[attribute.Key] = attribute.Value;
        }
    }
}
