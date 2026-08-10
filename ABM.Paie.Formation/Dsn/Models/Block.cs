using ABM.Paie.Formation.Dsn.Enums;
using Common.ExtensionsTemp;

namespace ABM.Paie.Formation.Dsn.Models;

public abstract class Block(Code code, Cardinality cardinality)
{
    public Code Code => code;
    public Cardinality Cardinality => cardinality;

    public override string ToString() => $"{Code.ToString().Replace('_', '.')} - {Code.Description} {Cardinality.Description}";
}
