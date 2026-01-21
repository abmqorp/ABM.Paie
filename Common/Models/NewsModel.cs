namespace Common.Models;
public sealed record NewsModel(string Title, UriModel Uri, string? Description = default);
