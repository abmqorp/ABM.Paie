using Common.Graphics.Extensions;
using Common.Graphics.Svg.Attributes;
using Common.Graphics.Svg.Enumerations;

namespace Common.Graphics.Svg.Extensions;

public static class EnumExtensions
{
    extension(Enum value)
    {
        private string GetPath() => value.Get<PathAttribute>()?.Path ?? value.ToString();
    }

    extension(Icon value)
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
}
