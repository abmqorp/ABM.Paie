using Microsoft.AspNetCore.Components;

namespace Common.Models;

public sealed record TabModel(UriModel Uri, RenderFragment? Content, bool IsHidden = true)
{
    public bool IsHidden { get; set; } = IsHidden;
}
