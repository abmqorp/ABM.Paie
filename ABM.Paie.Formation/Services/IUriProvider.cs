using ABM.Paie.Formation.Enumerations;
using Common.Models;

namespace ABM.Paie.Formation.Services;
public interface IUriProvider
{
    public UriModel Get(AbmUri value);
}
