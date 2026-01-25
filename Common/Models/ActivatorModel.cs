using Common.Enumerations;
using Common.Tools;

namespace Common.Models;

public sealed record ActivatorModel(IconPath? StartIcon = default, IconPath? EndIcon = default, ClassBuilder? Class = default)
    : BaseModel(Class)
{
    public IconPath? EndIcon { get; set; } = EndIcon;
}
