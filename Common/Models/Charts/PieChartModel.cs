using Common.Enumerations;
using Common.Models.General;
using Common.Tools.Builders;

namespace Common.Models.Charts;

public sealed record PieChartModel : ChartModel
{
    private const double Quadrant = 25;
    private const double SemiCircle = 2 * Quadrant;

    public PieChartModel(
        IEnumerable<ChartDetailModel> details,
        CaptionModel caption,
        string? description = null,
        double multiplier = 1.1)
        : base(caption, description, "common__piechart")
    {
        ViewBox = "-1 -1 2 2";

        var total = details.Sum(b => b.Count);
        var cumPercent = -Quadrant;
        var drawings = new List<Drawing>();

        foreach (var detail in details)
        {
            var start = Vector.Polar(1, cumPercent);
            var percent = detail.Count * 100 / total;
            cumPercent += percent;
            var end = Vector.Polar(1, cumPercent);
            var path = new PathBuilder(new(detail.Color, Contour: Color.White), true, detail.IsSelected, multiplier)
                .Move(start)
                .Arc(Vector.Ones, percent > SemiCircle, end)
                .Line(Vector.Zeros)
                .Close();

            _drawings.Add(new(
                path,
                "common__piechart__detail",
                new(detail.Color, detail.Title),
                detail.Description,
                $"{detail.Title} : {detail.Count / total:0.##%}"));
        }
    }
}
