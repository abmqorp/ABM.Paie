using Common.Enumerations;

namespace Common.Models;
public class LinkData(
    string url,
    string text,
    bool isExternal = false,
    IconPath? startIcon = null,
    string? cssClass = null,
    Color color = default) : OpData
{
    public string Url => url;
    public override string Text => text;
    public bool IsExternal => isExternal;
    public override IconPath? StartIcon => startIcon;
    public override string? Class => cssClass;
    public override Color Color => color;
}
