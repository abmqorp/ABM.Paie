using ABM.Paie.Formation.Enumerations;
using Common.Attributes;
using Common.Enumerations;
using Common.Extensions;
using Common.Models;

namespace ABM.Paie.Formation.Services;

public sealed class UriProvider(IConfiguration configuration) : IUriProvider
{
    public T Get<T>(AbmUri value) where T : UriModel => Get<T>(ComputeKey(value));
    public UriModel Get(AbmUri value)
        => Get<UriModel>(value)
        with
        {
            Image = value.Get<ImageAttribute>()?.Image is AbmImage image ? Get(image) : default,
            Parent = value.Get<ParentAttribute>()?.Parent is AbmUri parent ? Get<UriModel>(parent) : default,
        };
    public OperationModel Get(AbmMail value)
        => new(Get<UriModel>(ComputeKey(value)) with { IsExternal = true }, new(IconPath.Mail));
    public ImageModel Get(AbmImage value) => Get<ImageModel>(ComputeKey(value));
    public ImageModel Get(AbmImage value, double scale) => Get(value) with { Scale = scale };

    private T Get<T>(string value) => configuration.GetSection(value).Get<T>()
        ?? throw new KeyNotFoundException($"{value} was not present in appsettings.");

    private static string ComputeKey(Enum value)
        => $"{value switch
        {
            AbmUri _ => "uris",
            AbmMail _ => "mailtos",
            AbmImage _ => "images",
            _ => throw new NotSupportedException(),
        }}:{value.GetDescription()}";
}
