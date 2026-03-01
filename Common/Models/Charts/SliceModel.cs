using Common.Enumerations;

namespace Common.Models.Charts;

public sealed record SliceModel(string Title, double Count, double Total, double CumSum, string? Description = null, Color? Color = null, bool IsSelected = false)
    : BarModel(Title, Count, Description, Color, IsSelected)
{
    public double Percent => Count * 100 / Total;
    public double CumPercent => CumSum * 100 / Total;

    public SliceModel(BarModel model, double total, double cumulativeSum)
        : this(model.Title, model.Count, total, cumulativeSum, model.Description, model.Color, model.IsSelected) { }
}
