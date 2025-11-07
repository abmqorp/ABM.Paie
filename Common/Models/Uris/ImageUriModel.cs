namespace Common.Models.Uris;
public record ImageUriModel(
    string Label,
    ImageModel Image,
    string? Location = null,
    string? Description = null,
    string? Content = null,
    bool IsExternal = false)
    : DescriptionUriModel(Label, Location, Description, Content, IsExternal);
