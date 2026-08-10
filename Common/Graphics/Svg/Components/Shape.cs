using Common.Components;
using Common.Extensions;
using Microsoft.AspNetCore.Components;

namespace Common.Graphics.Svg.Components;

public abstract class Shape : CommonComponentBase
{
    [Parameter, EditorRequired]
    public Models.Shape Model { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object> AdditionalAttributes { get; set; } = new Dictionary<string, object>();

    public IDictionary<string, object> Attributes => Model.Attributes.Union(AdditionalAttributes).ToSafeDictionary();
}
