using Common.Tools.Builders;
using Microsoft.AspNetCore.Components;

namespace Common.Components;

public class CommonComponentBase : ComponentBase
{
    [Parameter]
    public ClassBuilder Class { get; set; } = new();
}
