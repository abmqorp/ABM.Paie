using Common.Models;

namespace Common.Extensions;
public static class UriModelExtensions
{
    public static UriModel ToBase(
        this UriModel model,
        string? anchor = default,
        string? content = default)
        => new(
            model.Label,
            model.Location + anchor,
            content ?? model.Content,
            model.IsExternal);
}
