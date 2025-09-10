namespace Common.Models;
public record UriModel(string Location, string Label, string? Content = null, bool IsExternal = false);
