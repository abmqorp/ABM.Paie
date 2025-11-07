using ABM.Paie.Formation.Enumerations;
using Common.Models;
using Common.Models.Operations;
using Common.Models.Uris;

namespace ABM.Paie.Formation.Services;
public interface IUriProvider
{
    T Get<T>(AbmUri value) where T : UriModel;
    OperationModel Get<T>(AbmMail value) where T : UriModel;
    UriModel Get(AbmUri value);
    OperationModel Get(AbmMail value);
    ImageModel Get(AbmImage value);
    ImageModel GetImage(AbmUri value);
}
