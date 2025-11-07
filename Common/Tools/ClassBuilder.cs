namespace Common.Tools;
public class ClassBuilder
{
    private const char Sep = ' ';

    private readonly HashSet<string> _classes = [];

    public ClassBuilder Append(string? str)
    {
        if (str is null) return this;

        var classes = str.Split(Sep);

        foreach (var c in classes)
        {
            if (!string.IsNullOrWhiteSpace(c)) _ = _classes.Add(c.Trim());
        }

        return this;
    }

    public override string ToString() => string.Join(Sep, _classes).Trim();
}
