using Common.Interfaces;

namespace Common.Models.Bases;

public record SelectableModel(bool IsSelected) : ISelectable
{
    public bool IsSelected { get; private set; } = IsSelected;

    public virtual void Toggle() => IsSelected = !IsSelected;
}
