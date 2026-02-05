using Common.Models.Bases;
using Microsoft.AspNetCore.Components;

namespace Common.Components.Bases;

public abstract class SelectableBase<T> : Base where T : SelectableModel
{
    [Parameter, EditorRequired]
    public IEnumerable<T> Templates { get; set; }

    protected virtual void Update(T model)
    {
        model.Toggle();

        foreach (var item in Templates.Except([model])) item.IsSelected = false;
    }

    protected override void OnInitialized()
    {
        foreach (var item in Templates.Where(m => m.IsSelected).Skip(1)) item.IsSelected = false;

        base.OnInitialized();
    }
}
