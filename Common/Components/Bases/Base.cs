using Common.Tools.Builders;
using Microsoft.AspNetCore.Components;

namespace Common.Components.Bases;

public abstract class Base : ComponentBase
{
    protected ClassBuilder _builder = new();

    [Parameter]
    public string? Class { get; set; }

    protected override void OnInitialized()
    {
        _ = _builder.Add(Class);
        base.OnInitialized();
    }
}
