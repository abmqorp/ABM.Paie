using System.ComponentModel;

namespace ABM.Paie.Formation.Enumerations;
public enum AbmMail
{
    [Description("paie-formation")]
    PaieFormation,
    [Description("ref-handicap")]
    RefHandicap,
    [Description("assistance")]
    Assistance,
    [Description("facturation")]
    Facturation,
    [Description("historique-versions")]
    HistoriqueVersions,
}
