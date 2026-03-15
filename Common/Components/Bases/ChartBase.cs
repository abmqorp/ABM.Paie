using Common.Enumerations;
using Common.Interfaces;
using Common.Models;
using Common.Models.General;
using Microsoft.AspNetCore.Components;

namespace Common.Components.Bases;

public abstract class ChartBase<T> : SelectableBase<T> where T : IDrawable
{
    [Parameter, EditorRequired]
    public string ViewBox { get; set; }
    [Parameter, EditorRequired]
    public CaptionModel Caption { get; set; }
    [Parameter, EditorRequired]
    public string? Description { get; set; }
    [Parameter, EditorRequired]
    public Reference Reference { get; set; }

    protected T? Drawing { get; set; }
    protected string? Style { get; set; }

    protected IEnumerable<KeyValuePair<Color, string>> Legends
        => Templates.Select(t => t.Legend).Where(t => t is not null).Cast<KeyValuePair<Color, string>>();

    protected void SetTip(TipEventArgs<IDrawable>? args)
    {
        Drawing = (T?)args?.Model;
        Style = args?.Style;
    }
}
