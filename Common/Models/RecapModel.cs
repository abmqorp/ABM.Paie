using Common.Extensions;

namespace Common.Models;
public sealed record RecapModel(DateOnly Date, string Title, ImageModel Image, IEnumerable<NewsModel> News)
{
    public string Id => "#" + Date.ToString("yyMM");
    public string LongDate => Date.ToString("MMMM yyyy").UpFirstChar();
    public UriModel Uri => new(Id, LongDate);
}
