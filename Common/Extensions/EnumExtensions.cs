using Common.Enumerations;
using System.ComponentModel;

namespace Common.Extensions;

public static class EnumExtensions
{
    extension(Enum value)
    {
        public T? Get<T>() where T : Attribute => (T?)value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(T), false)
            .SingleOrDefault();

        public string Description => value.Get<DescriptionAttribute>() is DescriptionAttribute attribute
            ? attribute.Description
            : value.ToString();
    }

    extension(Color value)
    {
        public string Var => $"var(--{value.Description})";
    }
}
