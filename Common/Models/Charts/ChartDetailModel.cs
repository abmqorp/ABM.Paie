using Common.Enumerations;
using Common.Models.Bases;

namespace Common.Models.Charts;

public record ChartDetailModel(string Title, double Count, string? Description = null, Color Color = Color.Gray, bool IsSelected = false)
    : SelectableModel(IsSelected);
