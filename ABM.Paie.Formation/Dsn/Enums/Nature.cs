using System.ComponentModel;

namespace ABM.Paie.Formation.Dsn.Enums;

public enum Nature
{
    [Description("DSN Mensuelle")]
    N01,

    [Description("Signalement Arrêt de travail")]
    N04,

    [Description("Signalement Reprise suite à arrêt de travail")]
    N05,

    [Description("Signalement Fin du contrat de travail unique")]
    N07,

    [Description("Signalement Amorçage des données variables")]
    N08,

    [Description("DSN de substitution")]
    N09,

    [Description("Signalement Déclaration préalable à l'embauche")]
    N10,
}
