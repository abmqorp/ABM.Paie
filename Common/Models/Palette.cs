using Common.Enumerations;

namespace Common.Models;

public record Palette(Color Default, Color? Selection = null, Color? Contour = null, Color Text = Color.GrayDark)
{
    public Color SelectionOrDefault => Selection ?? Default;
    public Color ContourOrDefault => Contour ?? Default;

    public static implicit operator Palette(Color color) => new(color);
}
