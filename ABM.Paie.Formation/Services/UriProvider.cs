using ABM.Paie.Formation.Enumerations;
using Common.Extensions;
using Common.Models;

namespace ABM.Paie.Formation.Services;
public class UriProvider(IConfiguration configuration) : IUriProvider
{
    public T Get<T>(AbmUri value) where T : UriModel => Get<T>(ComputeKey(value));
    public UriModel Get(AbmUri value) => Get<UriModel>(value);
    public ImageModel GetImage(AbmUri value) => Get<ImageModel>(ComputeImageKey(value));
    public ImageModel Get(AbmImageUri value) => Get<ImageModel>(ComputeKey(value));
    public UriModel Get(AbmMailUri value) => Get<UriModel>(ComputeKey(value));

    private T Get<T>(string value) => configuration.GetSection(value).Get<T>()
        ?? throw new KeyNotFoundException();

    private static string ComputeKey(AbmUri value) => $"uris:{value.GetDescription()}";
    private static string ComputeImageKey(AbmUri value) => $"{ComputeKey(value)}:image";
    private static string ComputeKey(AbmImageUri value) => $"images:{value.GetDescription()}";
    private static string ComputeKey(AbmMailUri value) => $"mailtos:{value.GetDescription()}";
}
