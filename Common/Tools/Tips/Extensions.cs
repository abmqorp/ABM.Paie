using Common.ExtensionsTemp;

namespace Common.Tools.Tips;

public static class Extensions
{
    extension(Position value)
    {
        public string Property => value.Get<PropertyAttribute>()?.Property ?? value.ToString();
    }
}
