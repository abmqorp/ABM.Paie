using Common.Models;

namespace Common.Tools;

public sealed class ClassBuilder
{
    private const char Sep = ' ';
    private readonly HashSet<string> _classes = [];

    public ClassBuilder(string? str = null) => Add(str);

    public static implicit operator ClassBuilder(string? str) => new(str);
    public static implicit operator string(ClassBuilder builder) => builder.ToString();

    public ClassBuilder Add(string? str) => Update(str, AddClass);
    public ClassBuilder Remove(string? str) => Update(str, RemoveClass);
    public override string ToString() => string.Join(Sep, _classes).Trim();

    private ClassBuilder Update(string? str, Action<string> action)
    {
        if (str is null) return this;

        var classes = str.Split(Sep);

        foreach (var c in classes)
        {
            if (!string.IsNullOrWhiteSpace(c)) action.Invoke(c);
        }

        return this;
    }

    private Action<string> AddClass => (str) => _ = _classes.Add(str);
    private Action<string> RemoveClass => (str) => _ = _classes.Remove(str);
}
