using Common.Graphics.Enumerations;
using Common.Graphics.Svg.Attributes;

namespace Common.Graphics.Svg.Enumerations;

public static class Extensions
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
