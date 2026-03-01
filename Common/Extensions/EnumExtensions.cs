using Common.Enumerations;
using System.ComponentModel;

namespace Common.Extensions;

public static class EnumExtensions
{
    extension(Enum value)
    {
        public string Description => value.Get<DescriptionAttribute>() is not DescriptionAttribute attribute
            ? value.ToString()
            : attribute.Description;

        public T? Get<T>() where T : Attribute => (T?)value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(T), false)
            .SingleOrDefault();
    }

    extension(Color value)
    {
        public string Var => $"var(--{value.Description})";
    }
}
