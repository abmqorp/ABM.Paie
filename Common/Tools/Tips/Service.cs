using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace Common.Tools.Tips;

public sealed class Service(IOptions<Options> options) : IDisposable
{
    private readonly Options _options = options.Value;

    private CancellationTokenSource? _pending;

    public event Action? Changed;

    public bool Visible { get; private set; }
    public RenderFragment? Content { get; private set; }
    public ElementReference Anchor { get; private set; }
    public Position Position { get; private set; } = Position.Top;
    public object? ActiveOwner { get; private set; }
    public int Version { get; private set; }

    public void Show(object owner, ElementReference anchor, RenderFragment content, Position position = Position.Top)
    {
        var token = ResetPending();

        // Already visible (moving between triggers) -> switch immediately, no flicker.
        if (Visible)
        {
            Apply(owner, anchor, content, position);
            return;
        }

        // First appearance -> small delay so quick passes do not open it.
        ActiveOwner = owner;
        _ = RunDelayed(() => Apply(owner, anchor, content, position), _options.ShowDelay, token);
    }

    public void Hide(object owner)
    {
        if (!ReferenceEquals(ActiveOwner, owner)) return; // stale hide from a previous trigger

        var token = ResetPending();

        if (!Visible)
        {
            ActiveOwner = null; // show was still pending -> cancel it
            return;
        }

        _ = RunDelayed(() =>
            {
                if (ReferenceEquals(ActiveOwner, owner)) HideCore();
            }, _options.HideDelay, token);
    }

    public void HideNow(object owner)
    {
        if (!ReferenceEquals(ActiveOwner, owner)) return;
        ResetPending();
        if (Visible) HideCore();
        else ActiveOwner = null;
    }

    // Refreshes content/placement when the owning trigger re-renders while its tooltip is open.
    public void Update(object owner, RenderFragment content, Position position)
    {
        if (!Visible || !ReferenceEquals(ActiveOwner, owner)) return;
        Content = content;
        Position = position;
        Version++;
        Changed?.Invoke();
    }

    private void Apply(object owner, ElementReference anchor, RenderFragment content, Position position)
    {
        ActiveOwner = owner;
        Anchor = anchor;
        Content = content;
        Position = position;
        Visible = true;
        Version++;
        Changed?.Invoke();
    }

    private void HideCore()
    {
        ActiveOwner = null;
        Visible = false;
        Version++;
        Changed?.Invoke();
    }

    private CancellationToken ResetPending()
    {
        _pending?.Cancel();
        _pending?.Dispose();
        _pending = new CancellationTokenSource();
        return _pending.Token;
    }

    private static async Task RunDelayed(Action action, TimeSpan delay, CancellationToken token)
    {
        try
        {
            await Task.Delay(delay, token);
            if (!token.IsCancellationRequested) action();
        }
        catch (TaskCanceledException) { }
    }

    public void Dispose()
    {
        _pending?.Cancel();
        _pending?.Dispose();
    }
}
