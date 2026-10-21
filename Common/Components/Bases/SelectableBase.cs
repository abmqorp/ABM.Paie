using Common.Interfaces;
using Microsoft.AspNetCore.Components;

namespace Common.Components.Bases;

public abstract class SelectableBase<T> : BaseTemp where T : ISelectable
{
    [Parameter, EditorRequired]
    public IEnumerable<T> Templates { get; set; }

    protected T? SelectedItem => Templates.FirstOrDefault(t => t.IsSelected);

    protected virtual void Update(T model, bool autoToggle = true)
    {
        model.Toggle();

        if (autoToggle)
        {
            foreach (var item in Templates.Except([model]).Where(t => t.IsSelected)) item.Toggle();
        }
    }

    protected override void OnInitialized()
    {
        foreach (var item in Templates.Where(m => m.IsSelected).Skip(1)) item.Toggle();

        base.OnInitialized();
    }
}
