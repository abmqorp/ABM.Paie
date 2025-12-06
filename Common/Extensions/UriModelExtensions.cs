using Common.Models;

namespace Common.Extensions;
public static class UriModelExtensions
{
    public static UriModel ToBase(
        this UriModel model,
        string? label = default,
        string? location = default,
        string? content = default,
        bool? isExternal = default)
        => new(
            label ?? model.Label,
            location ?? model.Location,
            content ?? model.Content,
            isExternal ?? model.IsExternal);
}
