namespace Common.Tools.Tips;

[AttributeUsage(AttributeTargets.Field)]
public sealed class PropertyAttribute(string property) : Attribute
{
    public string Property { get; } = property;
}
