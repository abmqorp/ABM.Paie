namespace Common.Models.Uris;
public record DescriptionUriModel(
    string Label,
    string? Location = null,
    string? Description = null,
    string? Content = null,
    bool IsExternal = false)
    : UriModel(Label, Location, Content, IsExternal);
