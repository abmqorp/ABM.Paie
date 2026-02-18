using Common.Extensions;
using Common.Models.General;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Common.Components.Bases;

public sealed record TipEventArgs<T>(T Content, string Style);
public abstract class TooltipBase : TooltipBase<string>;
public abstract class TooltipBase<T> : Base
{
    [Parameter, EditorRequired]
    public T Content { get; set; }
    [Parameter]
    public Point? Point { get; set; }
    [Parameter]
    public EventCallback OnActivated { get; set; }
    [Parameter]
    public EventCallback<TipEventArgs<T>?> OnChanged { get; set; }

    protected string Style
        => $"left: {Compute(Point?.X)}; top: {Compute(Point?.Y)}; transform: translate({Compute(Point?.X, 20, "-50%")}, {Compute(Point?.Y, 24, "-50%")});";
    protected void Activate() => OnActivated.InvokeAsync();
    protected virtual void Change(TipEventArgs<T>? args) => OnChanged.InvokeAsync(args);

    protected void Show()
    {
        Change(new(Content, Style));
    }

    protected void Hide()
    {
        Point = null;
        Change(null);
    }

    protected void Update(MouseEventArgs args)
    {
        Point = new(args.OffsetX, args.OffsetY);
        Change(new(Content, Style));
    }

    private static string Compute(double? position, double? translation = null, string fallback = "50%")
        => position is null ? fallback : $"{(translation ?? position).Invariant}px";
}
