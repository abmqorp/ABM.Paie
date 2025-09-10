using ABM.Paie.Formation.Enumerations;
using Common.Models;

namespace ABM.Paie.Formation.Services;
public interface IUriProvider
{
    public T Get<T>(AbmUri value) where T : UriModel;
    public UriModel Get(AbmUri value);
    public ImageModel GetImage(AbmUri value);
    public ImageModel Get(AbmImageUri value);
    public UriModel Get(AbmMailUri value);
}
