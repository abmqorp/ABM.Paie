using System.Text;

namespace Common.Tools;
public class ClassBuilder
{
    private readonly StringBuilder _sb = new();

    public ClassBuilder Append(string? str)
    {
        if (!string.IsNullOrEmpty(str))
        {
            _ = _sb.Append(str + " ");
        }

        return this;
    }

    public override string ToString() => _sb.ToString().Trim();
}
