namespace Common.Models;

public record UriModel(
    string? Location = default,
    string? Content = default,
    string? Label = default,
    bool IsExternal = default,
    ImageModel? Image = default,
    UriModel? Parent = default)
{
    private string? Anchor { get; init; } = Location;
    public string? Id => Anchor?.TrimStart('/', '#');
    public string? Location => Parent?.Location + Anchor;

    public UriModel ToBase(string? anchor = default, string? content = default)
        => new(Location + anchor, content ?? Content, Label, IsExternal);
}
