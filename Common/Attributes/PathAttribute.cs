namespace Common.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public sealed class PathAttribute(string path) : Attribute
{
    public string Path { get; } = path;
}
