using Common.Extensions;
using Common.Graphics.Enumerations;
using System.ComponentModel;

namespace Common.Graphics.Extensions;

public static class EnumExtensions
{
    extension(Enum value)
    {
        public T? Get<T>() where T : Attribute => (T?)value
            .GetType()
            .GetField(value.ToString())?
            .GetCustomAttributes(typeof(T), false)
            .SingleOrDefault();

        public string Description => value.Get<DescriptionAttribute>()?.Description ?? value.ToString();

        public string ToCamelCase() => value.ToString().ToCamelCase();
    }

    extension(Color value)
    {
        public string Var => $"var(--{value.Description})";
    }
}