using Common.Models;

namespace ABM.Paie.Formation.Services;

public interface INewsService
{
    List<RecapModel> Recaps { get; }
}
