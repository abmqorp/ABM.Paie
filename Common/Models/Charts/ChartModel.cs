using Common.Enumerations;
using Common.Interfaces;
using Common.Models.Bases;
using Common.Models.Svg;
using Common.Tools.Builders;

namespace Common.Models.Charts;

public abstract record ChartModel(CaptionModel Caption, string? Description, ClassBuilder? Class = null) : BaseModel(Class)
{
    protected sealed record Drawing(
        Shape Shape,
        ClassBuilder Class,
        KeyValuePair<Color, string>? Legend = null,
        string? Description = null,
        string? Tip = null)
        : SelectableModel(Shape.IsSelected), IDrawable
    {
        public override void Toggle()
        {
            base.Toggle();
            Shape.Toggle();
        }
    }
    protected List<Drawing> _drawings = [];
    public IEnumerable<IDrawable> Drawings => _drawings;
    public string? ViewBox { get; init; }
}
