namespace Common.Interfaces;

public interface ISelectable
{
    public bool IsSelected { get; }

    public void Toggle();
}
