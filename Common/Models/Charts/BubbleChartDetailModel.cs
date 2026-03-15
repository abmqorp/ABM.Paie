using Common.Enumerations;
using Common.Models.General;

namespace Common.Models.Charts;

public sealed record BubbleChartDetailModel(
    string Title,
    double Count,
    Vector Vector,
    string? Description = null,
    Color Color = Color.Gray,
    bool IsSelected = false)
    : ChartDetailModel(Title, Count, Description, Color, IsSelected);
