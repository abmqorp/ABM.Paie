using Common.Enumerations;

namespace Common.Models.Operations;
public record ActivatorModel(IconPath? StartIcon = null, string? Class = null) : BaseModel(Class)
{
    public IconPath? EndIcon { get; set; }
}
