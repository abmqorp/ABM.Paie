using ABM.Paie.Formation.Models;

namespace ABM.Paie.Formation.Services;

public interface INewsService
{
    List<RecapModel> Recaps { get; }
}
