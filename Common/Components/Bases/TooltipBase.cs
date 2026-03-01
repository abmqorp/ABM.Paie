using Common.Extensions;
using Common.Models.General;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Common.Components.Bases;

public sealed record TipEventArgs<T>(T Model, string Style);
public abstract class TooltipBase : TooltipBase<string>;
public abstract class TooltipBase<T> : Base
{
    [Parameter, EditorRequired]
    public T Model { get; set; }
    [Parameter]
    public EventCallback OnActivated { get; set; }
    [Parameter]
    public EventCallback<TipEventArgs<T>?> OnChanged { get; set; }

    protected Point? Point { get; set; }
    protected string Style
        => $"left: {Compute(Point?.X)}; top: {Compute(Point?.Y)}; transform: translate({Compute(Point?.X, 20, "-50%")}, {Compute(Point?.Y, 24, "-50%")});";

    private void Activate() => OnActivated.InvokeAsync();
    protected virtual void Activate(MouseEventArgs _) => Activate();
    protected void Activate(KeyboardEventArgs args)
    {
        if (args.Key is "Enter" or " ") Activate();
    }

    protected virtual void Change(TipEventArgs<T>? args) => OnChanged.InvokeAsync(args);

    private void Show() => Change(new(Model, Style));
    protected void Show(MouseEventArgs _) => Show();
    protected virtual void Show(FocusEventArgs _) => Show();


    protected void Hide()
    {
        Point = null;
        Change(null);
    }

    protected void Update(MouseEventArgs args)
    {
        Point = new(args.OffsetX, args.OffsetY);
        Change(new(Model, Style));
    }

    private static string Compute(double? position, double? translation = null, string fallback = "50%")
        => position is null ? fallback : $"{(translation ?? position).Invariant}px";
}
