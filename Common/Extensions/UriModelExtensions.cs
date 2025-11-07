using Common.Models.Uris;

namespace Common.Extensions;
public static class UriModelExtensions
{
    public static UriModel ToBase(
        this UriModel model,
        string? label = null,
        string? location = null,
        string? content = null,
        bool? isExternal = null)
        => new(
            label ?? model.Label,
            location ?? model.Location,
            content ?? model.Content,
            isExternal ?? model.IsExternal);
}
