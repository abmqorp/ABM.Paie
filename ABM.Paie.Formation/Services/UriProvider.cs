using ABM.Paie.Formation.Enumerations;
using Common.Extensions;
using Common.Models;

namespace ABM.Paie.Formation.Services;
public class UriProvider(IConfiguration configuration) : IUriProvider
{
    public UriModel Get(AbmUri value) => configuration.GetSection($"uris:{value.GetDescription()}").Get<UriModel>() ?? throw new KeyNotFoundException();
}
