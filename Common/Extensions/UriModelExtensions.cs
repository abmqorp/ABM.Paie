using Common.Enumerations;
using Common.Models;

namespace Common.Extensions;

public static class UriModelExtensions
{
    public static UriModel ToBase(this UriModel model, string? anchor = default, string? content = default)
        => new(
            model.Location + anchor,
            content ?? model.Content,
            model.Label,
            model.IsExternal);

    public static OperationModel ToDefaultOperation(this UriModel model, string? anchor = default, string? activatorClass = default)
        => new(
            model.ToBase(anchor, "en savoir plus"),
            new(EndIcon: IconPath.ArrowCircleRight, Class: activatorClass));
}
