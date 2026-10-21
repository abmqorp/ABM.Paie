using Common.Enumerations;
using Common.ExtensionsTemp;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Common.Tools.Tips;

public class Trigger() : Components.Base, IDisposable
{
    [Inject]
    protected Service ToolTip { get; set; } = default!;
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
    [Parameter]
    public RenderFragment? TooltipContent { get; set; }
    [Parameter]
    public string? Text { get; set; }
    [Parameter]
    public Position Position { get; set; } = Position.Top;

    // Set to false when ChildContent is already focusable (e.g. a button) to avoid a duplicate tab stop.
    [Parameter] public bool Focusable { get; set; } = true;

    protected ElementReference _elementReference;

    protected Dictionary<string, object?> TooltipAttributes => Text is null && TooltipContent is null ? new() : new([
        new("tabindex", Focusable ? "0" : null),
        new("aria-describedby", IsActive ? "app-tooltip" : null),
        new("onmouseenter", EventCallback.Factory.Create(this, Show)),
        new("onmouseleave", EventCallback.Factory.Create(this, Hide)),
        new("onfocusin", EventCallback.Factory.Create(this, Show)),
        new("onfocusout", EventCallback.Factory.Create(this, Hide)),
        new("onkeydown", EventCallback.Factory.Create<KeyboardEventArgs>(this, OnKeyDown)),
    ]);

    protected override void OnParametersSet() => ToolTip.Update(this, Content, Position);
    private bool IsActive => ReferenceEquals(ToolTip.ActiveOwner, this) && ToolTip.Visible;
    private RenderFragment Content => TooltipContent ?? (b => b.AddContent(0, Text));

    private void Show() => ToolTip.Show(this, _elementReference, Content, Position);
    private void Hide() => ToolTip.Hide(this);

    private void OnKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == Keyboard.Escape.Key) ToolTip.HideNow(this);
    }

    public void Dispose()
    {
        ToolTip.HideNow(this);
        GC.SuppressFinalize(this);
    }
}
