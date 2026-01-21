namespace Common.Models;
public record UriModel(
    string? Location = default,
    string? Content = default,
    string? Label = default,
    bool IsExternal = default,
    string? Description = default,
    ImageModel? Image = default,
    UriModel? Parent = default)
{
    public string? Anchor { get; init; } = Location;
    public string? Location => Parent?.Location + Anchor;
}
