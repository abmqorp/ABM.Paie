namespace Common.Models;
public class UriModel(
    string uri,
    string label,
    string? content = null,
    bool isExternal = false,
    string? image = null)
{
    public string Uri { get; } = uri;
    public string Label { get; } = label;
    public string? Content { get; } = content;
    public bool IsExternal { get; } = isExternal;
    public string? Image { get; } = image;

    public static implicit operator string(UriModel data) => data.Uri;
}
