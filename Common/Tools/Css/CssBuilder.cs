namespace Common.Tools.Css;

public sealed class CssBuilder
{
    private static readonly char Sep = ' ';

    private readonly HashSet<string> _classes = [];

    public CssBuilder(string? str = null) => Add(str);

    public static implicit operator CssBuilder(string? str) => new(str);
    public static implicit operator string(CssBuilder builder) => builder.ToString();

    public CssBuilder Add(string? str) => Build(str, AddClass);
    public CssBuilder Add(params string?[] strings)
    {
        foreach (var str in strings) Update(str, AddClass);

        return this;
    }

    public CssBuilder Remove(string? str) => Build(str, RemoveClass);
    public override string ToString() => string.Join(Sep, _classes).Trim();

    private CssBuilder Build(string? str, Action<string> action)
    {
        Update(str, action);

        return this;
    }

    private static void Update(string? str, Action<string> action)
    {
        if (str is not null) foreach (var s in str.Split(Sep)) if (!string.IsNullOrWhiteSpace(s)) action.Invoke(s);
    }

    private Action<string> AddClass => (str) => _ = _classes.Add(str);
    private Action<string> RemoveClass => (str) => _ = _classes.Remove(str);
}
