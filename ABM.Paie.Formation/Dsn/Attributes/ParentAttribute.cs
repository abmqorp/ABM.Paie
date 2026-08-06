using ABM.Paie.Formation.Dsn.Enums;

namespace ABM.Paie.Formation.Dsn.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public sealed class ParentAttribute(Code parent) : Attribute
{
    public Code Parent { get; } = parent;
}
