using Common.Enumerations;
using Common.Interfaces;

namespace Common.Models.Svg;

public abstract record Shape(
    Palette Palette,
    bool IsFocusable = default,
    bool IsSelected = default,
    string? Content = null,
    double Multiplier = 1)
    : ISelectable
{
    public bool IsSelected { get; private set; } = IsSelected;
    public Color Color => IsSelected ? Palette.SelectionOrDefault : Palette.Default;
    public abstract IEnumerable<KeyValuePair<string, object>> Attributes { get; }

    public virtual void Toggle() => IsSelected = !IsSelected;
}
