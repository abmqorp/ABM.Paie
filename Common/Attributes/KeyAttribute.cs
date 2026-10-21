namespace Common.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public sealed class KeyAttribute(string key) : Attribute
{
    public string Key { get; } = key;
}
