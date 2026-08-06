using ABM.Paie.Formation.Dsn.Attributes;
using System.ComponentModel;

namespace ABM.Paie.Formation.Dsn.Enums;

public enum Code
{
    /**********/
    /* NEODeS */
    /**********/

    [Description("Envoi")]
    S10_G00_00 = 1,

    [Description("Émetteur")]
    [Parent(S10_G00_00)]
    S10_G00_01 = 2,

    [Description("Contact Émetteur")]
    [Parent(S10_G00_00)]
    S10_G00_02 = 3,

    [Description("Déclaration")]
    [Parent(S10_G00_00)]
    S20_G00_05 = 4,

    [Description("Entreprise")]
    [Parent(S20_G00_05)]
    S21_G00_06 = 7,

    [Description("Contact chez le déclaré")]
    [Parent(S20_G00_05)]
    S20_G00_07 = 5,

    [Description("Identifiant de l'organisme destinataire de la déclaration « Absence de rattachement pour le mois principal déclaré »")]
    [Parent(S20_G00_05)]
    S20_G00_08 = 6,

    [Description("Établissement")]
    [Parent(S21_G00_06)]
    S21_G00_11 = 9,

    [Description("Coordonnées bancaires spécifiques")]
    [Parent(S21_G00_11)]
    S21_G00_12 = 10,

    [Description("Complément OETH")]
    [Parent(S21_G00_06)]
    S21_G00_13 = 8,

    [Description("Adhésion Prévoyance")]
    [Parent(S21_G00_11)]
    S21_G00_15 = 11,

    [Description("Changements destinataire Adhésion Prévoyance")]
    [Parent(S21_G00_15)]
    S21_G00_16 = 12,

    [Description("Versement organisme de protection sociale")]
    [Parent(S21_G00_11)]
    S21_G00_20 = 14,

    [Description("Bordereau de cotisation due")]
    [Parent(S21_G00_11)]
    S21_G00_22 = 16,

    [Description("Cotisation agrégée")]
    [Parent(S21_G00_22)]
    S21_G00_23 = 17,

    [Description("Individu")]
    [Parent(S21_G00_11)]
    S21_G00_30 = 19,

    [Description("Changements Individu")]
    [Parent(S21_G00_30)]
    S21_G00_31 = 20,

    [Description("Compte Professionnel de Prévention (ex-pénibilité)")]
    [Parent(S21_G00_30)]
    S21_G00_34 = 21,

    [Description("Contrat (contrat de travail, convention, mandat")]
    [Parent(S21_G00_30)]
    S21_G00_40 = 22,

    [Description("Changements Contrat")]
    [Parent(S21_G00_40)]
    S21_G00_41 = 23,

    [Description("Assujettissement fiscal")]
    [Parent(S21_G00_11)]
    S21_G00_44 = 18,

    [Description("Données précédemment déclarées")]
    [Parent(S21_G00_40)]
    S21_G00_45 = 24,

    [Description("Versement Individu")]
    [Parent(S21_G00_30)]
    S21_G00_50 = 35,

    [Description("Rénumération")]
    [Parent(S21_G00_50)]
    S21_G00_51 = 36,

    [Description("Prime, gratification et indemnité")]
    [Parent(S21_G00_50)]
    S21_G00_52 = 38,

    [Description("Activité")]
    [Parent(S21_G00_51)]
    S21_G00_53 = 37,

    [Description("Autre élément de revenu brut")]
    [Parent(S21_G00_50)]
    S21_G00_54 = 40,

    [Description("Composant de versement")]
    [Parent(S21_G00_20)]
    S21_G00_55 = 15,

    [Description("Régularisation de prélèvement à la source")]
    [Parent(S21_G00_50)]
    S21_G00_56 = 41,

    [Description("Élément de revenu calculé en net")]
    [Parent(S21_G00_50)]
    S21_G00_58 = 42,

    [Description("Élément de revenu associé à des droits spécifiques")]
    [Parent(S21_G00_50)]
    S21_G00_59 = 39,

    [Description("Arrêt de travail")]
    [Parent(S21_G00_40)]
    S21_G00_60 = 25,

    [Description("Fin du contrat")]
    [Parent(S21_G00_40)]
    S21_G00_62 = 27,

    [Description("Préavis de fin de contrat")]
    [Parent(S21_G00_62)]
    S21_G00_63 = 28,

    [Description("Autre suspension de l'exécution du contrat")]
    [Parent(S21_G00_40)]
    S21_G00_65 = 29,

    [Description("Temps partiel thérapeutique")]
    [Parent(S21_G00_60)]
    S21_G00_66 = 26,

    [Description("Affiliation Prévoyance")]
    [Parent(S21_G00_40)]
    S21_G00_70 = 31,

    [Description("Retraite complémentaire")]
    [Parent(S21_G00_40)]
    S21_G00_71 = 33,

    [Description("Affiliation à tort à un régime de retraite complémentaire")]
    [Parent(S21_G00_71)]
    S21_G00_72 = 34,

    [Description("Ayant-droit")]
    [Parent(S21_G00_70)]
    S21_G00_73 = 32,

    [Description("Aménagement du temps de travail")]
    [Parent(S21_G00_40)]
    S21_G00_75 = 30,

    [Description("Base assujettie")]
    [Parent(S21_G00_50)]
    S21_G00_78 = 43,

    [Description("Composant de base assujettie")]
    [Parent(S21_G00_78)]
    S21_G00_79 = 44,

    [Description("Cotisation individuelle")]
    [Parent(S21_G00_78)]
    S21_G00_81 = 45,

    [Description("Cotisation Établissement")]
    [Parent(S21_G00_11)]
    S21_G00_82 = 13,

    [Description("Période d'affiliation à tort à un régime de retraite complémentaire")]
    [Parent(S21_G00_50)]
    S21_G00_83 = 46,

    [Description("Base assujettie déclarée à tort pour un régime de retraite complémentaire")]
    [Parent(S21_G00_83)]
    S21_G00_84 = 47,

    [Description("Lieu de travail ou établissement utilisateur")]
    [Parent(S20_G00_05)]
    S21_G00_85 = 51,

    [Description("Ancienneté")]
    [Parent(S21_G00_30)]
    S21_G00_86 = 49,

    [Description("Base assujettie déclarée à tort pour un régime de base risque maladie, AT/MP ou vieillesse")]
    [Parent(S21_G00_50)]
    S21_G00_95 = 48,

    [Description("Saisie administrative à tiers détenteur")]
    [Parent(S21_G00_30)]
    S21_G00_98 = 50,

    [Description("Bénéficiaire des honoraires")]
    [Parent(S20_G00_05)]
    S89_G00_32 = 52,

    [Description("Avantages en nature")]
    [Parent(S89_G00_32)]
    S89_G00_33 = 53,

    [Description("Prise en charge des indemnités")]
    [Parent(S89_G00_32)]
    S89_G00_35 = 54,

    [Description("Rénumérations")]
    [Parent(S89_G00_32)]
    S89_G00_43 = 55,

    [Description("Droit supplémentaire acquis au titre des régimes de retraite supplémentaire à prestations définies")]
    [Parent(S20_G00_05)]
    S89_G00_67 = 56,

    [Description("Actions gratuites")]
    [Parent(S20_G00_05)]
    S89_G00_87 = 57,

    [Description("Options sur titres (stock options)")]
    [Parent(S20_G00_05)]
    S89_G00_88 = 58,

    [Description("Bons de souscription de parts de créateur d'entreprise (BSPCE)")]
    [Parent(S20_G00_05)]
    S89_G00_89 = 59,

    [Description("Individu non salarié")]
    [Parent(S20_G00_05)]
    S89_G00_91 = 60,

    [Description("Bases spécifiques Individu non salarié")]
    [Parent(S89_G00_91)]
    S89_G00_92 = 61,

    [Description("Régularisation de prélèment à la source")]
    [Parent(S89_G00_92)]
    S89_G00_93 = 62,

    [Description("Cotisation Individu non salarié")]
    [Parent(S89_G00_92)]
    S89_G00_94 = 63,

    [Description("Total de l'envoi")]
    S90_G00_90 = 64,

    /**********/
    /* NEOReS */
    /**********/

    [Description("Envoi")]
    RO = 101,

    [Description("Flux DSN de rattachement")]
    [Parent(RO)]
    RO_B000 = 102,

    [Description("Retour organisme")]
    [Parent(RO)]
    RO_B001 = 103,

    [Description("Contexte")]
    [Parent(RO_B001)]
    RO_B002 = 104,

    [Description("Validation des données DSN")]
    [Parent(RO_B002)]
    RO_B003 = 105,

    [Description("Cible d'action")]
    [Parent(RO_B002)]
    RO_B004 = 106,

    [Description("Détail de l'action")]
    [Parent(RO_B004)]
    RO_B005 = 107,

    [Description("Identifiants individu (anomalie)")]
    [Parent(RO_B005)]
    RO_B006 = 108,

    [Description("Données DSN")]
    [Parent(RO_B005)]
    RO_B007 = 109,

    [Description("Paramètre à prendre en compte en paie")]
    [Parent(RO_B004)]
    RO_B008 = 111,

    [Description("Données d'identification d'un individu en écart")]
    [Parent(RO_B004)]
    RO_B009 = 112,

    [Description("Valeur acceptée")]
    [Parent(RO_B007)]
    RO_B010 = 110,

    [Description("Information")]
    [Parent(RO_B002)]
    RO_B011 = 113,

    [Description("Identifiants Individu (information)")]
    [Parent(RO_B011)]
    RO_B012 = 114,
}
