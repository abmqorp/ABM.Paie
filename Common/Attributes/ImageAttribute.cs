namespace Common.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public sealed class ImageAttribute(object image) : Attribute
{
    public object Image { get; } = image;
}
