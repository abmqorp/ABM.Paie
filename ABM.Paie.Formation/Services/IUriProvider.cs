using ABM.Paie.Formation.Enumerations;
using Common.Models;

namespace ABM.Paie.Formation.Services;
public interface IUriProvider
{
    T Get<T>(AbmUri value) where T : UriModel;
    UriModel Get(AbmUri value);
    ImageModel GetImage(AbmUri value);
    ImageModel Get(AbmImageUri value);
    UriModel Get(AbmMailUri value);
}
