using Common.Extensions;
using Microsoft.AspNetCore.Components;

namespace Common.Graphics.Svg.Components;

public abstract class Shape : Tools.Tips.Trigger
{
    [Parameter, EditorRequired]
    public Models.Shape Model { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public IDictionary<string, object?> AdditionalAttributes { get; set; } = new Dictionary<string, object?>();

    public IDictionary<string, object?> Attributes => Model.Attributes
        .Union(AdditionalAttributes)
        .Union(TooltipAttributes)
        .ToSafeDictionary();
}
