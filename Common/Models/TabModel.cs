using Microsoft.AspNetCore.Components;

namespace Common.Models;

public sealed record TabModel(OperationModel Operation, RenderFragment? Content, bool IsHidden = true)
{
    public bool IsHidden { get; set; } = IsHidden;
}
