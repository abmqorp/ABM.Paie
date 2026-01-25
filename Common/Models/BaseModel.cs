using Common.Tools;

namespace Common.Models;

public record BaseModel(ClassBuilder? Class = default)
{
    public ClassBuilder Class { get; init; } = Class ?? new();
}
