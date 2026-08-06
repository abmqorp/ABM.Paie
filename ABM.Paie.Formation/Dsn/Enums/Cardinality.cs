using System.ComponentModel;

namespace ABM.Paie.Formation.Dsn.Enums;

public enum Cardinality
{
    [Description("(0,1)")]
    C01,
    [Description("(0,*)")]
    C0N,
    [Description("(1,1)")]
    C11,
    [Description("(1,2)")]
    C12,
    [Description("(1,*)")]
    C1N,
}
