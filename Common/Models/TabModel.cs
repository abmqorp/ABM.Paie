using Common.Models.Bases;
using Microsoft.AspNetCore.Components;

namespace Common.Models;

public sealed record TabModel(OperationModel Operation, RenderFragment? Content, bool IsSelected = false) : SelectableModel(IsSelected);
