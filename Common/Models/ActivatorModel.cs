using Common.Enumerations;

namespace Common.Models;
public class ActivatorModel(
    IconPath? startIcon = null,
    IconPath? endIcon = null,
    string? cssClass = null) : BaseModel(cssClass)
{
    public IconPath? StartIcon { get; } = startIcon;
    public IconPath? EndIcon { get; set; } = endIcon;
}
