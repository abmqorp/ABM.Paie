using Common.Tools.Builders;

namespace Common.Models.Bases;

public record BaseModel(ClassBuilder? Class = default)
{
    public ClassBuilder Class { get; init; } = Class ?? new();
}
