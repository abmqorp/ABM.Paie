using ABM.Paie.Formation.Dsn.Enums;

namespace ABM.Paie.Formation.Dsn.Models;

public sealed class Return(KeyValuePair<Code, (Trigger Trigger, Cardinality Cardinality)> declaration)
    : Block(declaration.Key, declaration.Value.Cardinality)
{
    public Trigger Trigger => declaration.Value.Trigger;
}
