using Common.Enumerations;

namespace Common.Models;
public record ActivatorModel(IconPath? StartIcon = null, IconPath? EndIcon = null, string? Class = null) : BaseModel(Class)
{
    public IconPath? EndIcon { get; set; } = EndIcon;
}
