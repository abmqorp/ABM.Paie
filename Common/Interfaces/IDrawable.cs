using Common.Enumerations;
using Common.Models.Svg;
using Common.Tools.Builders;

namespace Common.Interfaces;

public interface IDrawable : ISelectable
{
    public Shape Shape { get; }
    public ClassBuilder Class { get; }
    public KeyValuePair<Color, string>? Legend { get; }
    public string? Description { get; }
    public string? Tip { get; }
}
