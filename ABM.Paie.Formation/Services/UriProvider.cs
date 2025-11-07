using ABM.Paie.Formation.Enumerations;
using Common.Enumerations;
using Common.Extensions;
using Common.Models;
using Common.Models.Operations;
using Common.Models.Uris;

namespace ABM.Paie.Formation.Services;
public class UriProvider(IConfiguration configuration) : IUriProvider
{
    public T Get<T>(AbmUri value) where T : UriModel => Get<T>(ComputeKey(value));
    public OperationModel Get<T>(AbmMail value) where T : UriModel
        => new(Get<T>(ComputeKey(value)) with { IsExternal = true }, new(IconPath.Mail));
    public UriModel Get(AbmUri value) => Get<UriModel>(value);
    public OperationModel Get(AbmMail value) => Get<UriModel>(value);
    public ImageModel Get(AbmImage value) => Get<ImageModel>(ComputeKey(value));
    public ImageModel GetImage(AbmUri value) => Get<ImageModel>(ComputeImageKey(value));

    private T Get<T>(string value) => configuration.GetSection(value).Get<T>() ?? throw new KeyNotFoundException();

    private static string ComputeKey(AbmUri value) => $"uris:{value.GetDescription()}";
    private static string ComputeKey(AbmMail value) => $"mailtos:{value.GetDescription()}";
    private static string ComputeKey(AbmImage value) => $"images:{value.GetDescription()}";
    private static string ComputeImageKey(AbmUri value) => $"{ComputeKey(value)}:image";
}
