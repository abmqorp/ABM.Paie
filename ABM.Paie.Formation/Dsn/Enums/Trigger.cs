using System.ComponentModel;

namespace ABM.Paie.Formation.Dsn.Enums;

public enum Trigger
{
    [Description("Retour organisme sur une DSN mensuelle ou un signalement d'événement")]
    T01,

    [Description("Retour organisme en fin d'exercice")]
    T02,

    [Description("Retour organisme pour rappel d'actions non réalisées")]
    T03,

    [Description("Retour organisme pour signaler un paramètre utile en paie")]
    T04,

    [Description("Retour organisme récapitulatif des substitutions de données opérées par l’organisme")]
    T05,

    [Description("Retour organisme informatif")]
    T06,

}
