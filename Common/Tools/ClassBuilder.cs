using System.Text;

namespace Common.Tools;
public class ClassBuilder
{
    private readonly StringBuilder _sb = new();

    public ClassBuilder Append(string? str)
    {
        if (!string.IsNullOrWhiteSpace(str)) _ = _sb.Append(str.Trim() + " ");

        return this;
    }

    public override string ToString() => _sb.ToString().Trim();
}
