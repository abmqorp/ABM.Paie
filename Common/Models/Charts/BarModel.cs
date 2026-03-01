using Common.Enumerations;
using Common.Models.Bases;

namespace Common.Models.Charts;

public record BarModel(string Title, double Count, string? Description = null, Color? Color = null, bool IsSelected = false) : SelectableModel(IsSelected);
