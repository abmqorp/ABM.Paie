namespace Common.Models.Uris;
public record UriModel(
    string Label,
    string? Location,
    string? Content = null,
    bool IsExternal = false);
