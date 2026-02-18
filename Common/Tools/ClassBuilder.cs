namespace Common.Tools;

public sealed class ClassBuilder
{
    private const char Sep = ' ';

    private readonly HashSet<string> _classes = [];

    public ClassBuilder(string? str = null) => Add(str);

    public static implicit operator ClassBuilder(string? str) => new(str);
    public static implicit operator string(ClassBuilder builder) => builder.ToString();

    public ClassBuilder Add(string? str) => Build(str, AddClass);
    public ClassBuilder Add(params string?[] strings)
    {
        foreach (var str in strings) Update(str, AddClass);

        return this;
    }

    public ClassBuilder Remove(string? str) => Build(str, RemoveClass);
    public override string ToString() => string.Join(Sep, _classes).Trim();

    private ClassBuilder Build(string? str, Action<string> action)
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
