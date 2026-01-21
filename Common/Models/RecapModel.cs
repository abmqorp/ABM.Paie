namespace Common.Models;
public sealed record RecapModel(DateOnly Date, string Title, ImageModel Image, IEnumerable<NewsModel> News);
