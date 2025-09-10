namespace Common.Models;
public record UriImageModel(string Location, string Label, ImageModel Image, string? Content = null, bool IsExternal = false)
    : UriModel(Location, Label, Content, IsExternal);
