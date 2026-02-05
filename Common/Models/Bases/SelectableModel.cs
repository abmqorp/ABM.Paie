namespace Common.Models.Bases;

public record SelectableModel(bool IsSelected)
{
    public bool IsSelected { get; set; } = IsSelected;

    public void Toggle() => IsSelected = !IsSelected;
}
