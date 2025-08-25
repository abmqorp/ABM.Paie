using Common.Enumerations;

namespace Common.Models;
public abstract class OpData
{
    public abstract string? Text { get; }
    public abstract IconPath? StartIcon { get; }
    public abstract string? Class { get; }
    public abstract Color Color { get; }
}
