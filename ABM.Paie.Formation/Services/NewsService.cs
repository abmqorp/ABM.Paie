using ABM.Paie.Formation.Enumerations;
using Common.Models;

namespace ABM.Paie.Formation.Services;
public sealed class NewsService : INewsService
{
    private readonly IUriProvider _uriProvider;

    public List<RecapModel> Recaps { get; }

    public NewsService(IUriProvider uriProvider)
    {
        _uriProvider = uriProvider;

        Recaps = Initialize();
    }

    private List<RecapModel> Initialize()
    {
        IEnumerable<NewsModel> absences = [
            new(
                "Cette formation pointue détaille toutes les subtilités du retrait des absences dans le logiciel MySilae selon les méthodes réelles ou moyennes en heures ou en calendaire.",
                _uriProvider.Get(AbmUri.Perfectionnement)),
        ];

        IEnumerable<NewsModel> certifications = [
            new(
                "Obtention de la certification QUALIOPI (21 mars 2025).",
                _uriProvider.Get(AbmUri.Qualiopi)),
            new(
                "Référente Handicap avec 2 nouvelles formations (février et mars 2025).",
                _uriProvider.Get(AbmUri.RefHandicap),
                [
                    "Devenir référent handicap en organisme de formation ou CFA",
                    "Troubles cognitifs (« Dys », autisme) : Connaître comprendre et aménager les parcours de formation"
                ]),
            new(
                "20/20 à la soutenance de mi-parcours (05 avril 2025) de mon projet <i>Former sur le processus des déclarations sociales en paie, de A à Z, en incluant des modules d'apprentissage numérique.</i>",
                _uriProvider.Get(AbmUri.Cafel)),
        ];

        return [
            new(
                new(2024, 12, 01),
                "Absences en heures mensualisées",
                _uriProvider.Get(AbmImage.Absences),
                absences),
            new(
                new(2025, 04, 01),
                "Nouvelles certifications",
                _uriProvider.Get(AbmImage.Certifications),
                certifications),
        ];
    }
}
