namespace Common.Models;

public sealed record NewsModel(string Title, UriModel Uri, IEnumerable<string>? Descriptions = default);
