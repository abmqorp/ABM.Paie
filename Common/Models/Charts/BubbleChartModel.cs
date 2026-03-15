using Common.Enumerations;
using Common.Models.Svg;

namespace Common.Models.Charts;

public sealed record BubbleChartModel : ChartModel
{
    public BubbleChartModel(
        IEnumerable<BubbleChartDetailModel> details,
        CaptionModel caption,
        IEnumerable<Svg.Path> contours,
        string viewBox,
        string? description = null,
        string? unit = null,
        Func<double, double>? transform = null)
        : base(caption, description, "common__bubblechart")
    {
        ViewBox = viewBox;
        _drawings.AddRange(contours.Select(c => new Drawing(c, "common__bubblechart__detail")));

        foreach (var detail in details.OrderByDescending(r => r.Count))
        {
            double radius(Func<double, double>? function) => function?.Invoke(detail.Count) ?? detail.Count;

            _drawings.Add(new(
                new Circle(detail.Vector.X, detail.Vector.Y, radius(transform), new(Color.Primary, Contour: Color.PrimaryDark), true, detail.IsSelected),
                "common__bubblechart__detail",
                null,
                null,
                $"{detail.Title} : {detail.Count:0.##}{unit}"));
        }
    }
}
