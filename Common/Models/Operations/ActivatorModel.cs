using Common.Enumerations;

namespace Common.Models.Operations;

public sealed record ActivatorModel(IconPath? StartIcon = default, IconPath? EndIcon = default, string? Class = default)
    : BaseModel(Class)
{
    public IconPath? EndIcon { get; set; } = EndIcon;
}
