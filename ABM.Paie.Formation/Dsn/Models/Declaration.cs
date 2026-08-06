using ABM.Paie.Formation.Dsn.Enums;

namespace ABM.Paie.Formation.Dsn.Models;

public sealed class Declaration(KeyValuePair<Code, (Nature Nature, Cardinality Cardinality)> declaration)
    : Block(declaration.Key, declaration.Value.Cardinality)
{
    public Nature Nature => declaration.Value.Nature;
}
