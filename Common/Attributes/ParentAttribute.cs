namespace Common.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public sealed class ParentAttribute(object parent) : Attribute
{
    public object Parent { get; } = parent;
}
