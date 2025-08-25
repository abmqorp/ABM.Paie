using Common.Enumerations;

namespace Common.Models;
public class ButtonData(
    string text,
    Action? action = null,
    IconPath? endIcon = null,
    IconPath? startIcon = null,
    string? cssClass = null,
    Color color = default) : OpData
{
    public override string Text => text;
    public Action? Action { get; set; } = action;
    public IconPath? EndIcon { get; set; } = endIcon;
    public override IconPath? StartIcon => startIcon;
    public override string? Class => cssClass;
    public override Color Color => color;
}
