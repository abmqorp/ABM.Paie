using Common.Attributes;
using Common.Enumerations;
using Common.Enumerations.Svg;
using System.ComponentModel;

namespace Common.ExtensionsTemp;

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

        private string GetPath() => value.Get<PathAttribute>()?.Path ?? value.ToString();
    }

    extension(Color value)
    {
        public string Var => $"var(--{value.Description})";
    }

    extension(SvgIcon value)
    {
        public string Path => value.GetPath();
    }

    extension(Region value)
    {
        public string Path => value.GetPath();
    }

    extension(Department value)
    {
        public string Path => value.GetPath();
    }

    extension(Keyboard value)
    {
        public string Key => value.Get<KeyAttribute>()?.Key ?? value.ToString();
    }
}
