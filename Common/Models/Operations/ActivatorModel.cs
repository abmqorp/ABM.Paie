using Common.Enumerations;

namespace Common.Models.Operations;
public sealed record ActivatorModel(IconPath? StartIcon = default, string? Class = default) : BaseModel(Class)
{
    public IconPath? EndIcon { get; set; }
}
