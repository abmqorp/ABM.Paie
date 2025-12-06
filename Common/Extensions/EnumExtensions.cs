using System.ComponentModel;

namespace Common.Extensions;
public static class EnumExtensions
{
    public static T? Get<T>(this Enum value) where T : Attribute
        => (T?)value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(T), false)
            .SingleOrDefault();

    public static string GetDescription(this Enum value)
        => value.Get<DescriptionAttribute>() is not DescriptionAttribute attribute
            ? value.ToString()
            : attribute.Description;
}
