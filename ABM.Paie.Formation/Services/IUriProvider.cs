using ABM.Paie.Formation.Enumerations;
using Common.Models;

namespace ABM.Paie.Formation.Services;

public interface IUriProvider
{
    T Get<T>(AbmUri value) where T : UriModel;
    UriModel Get(AbmUri value);
    OperationModel Get(AbmMail value);
    ImageModel Get(AbmImage value);
    ImageModel Get(AbmImage value, double scale);
}
