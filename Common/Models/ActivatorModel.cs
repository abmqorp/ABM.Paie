using Common.Enumerations.Svg;
using Common.Models.Bases;
using Common.Tools.Builders;

namespace Common.Models;

public sealed record ActivatorModel(SvgIcon? StartIcon = default, SvgIcon? EndIcon = default, ClassBuilder? Class = default)
    : BaseModel(Class)
{
    public SvgIcon? EndIcon { get; set; } = EndIcon;
}
