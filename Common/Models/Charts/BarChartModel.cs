using Common.Models.Svg;

namespace Common.Models.Charts;

public sealed record BarChartModel : ChartModel
{
    public BarChartModel(
        IEnumerable<ChartDetailModel> details,
        IEnumerable<int> axes,
        CaptionModel caption,
        Palette palette,
        string? description = null,
        string? unit = null)
        : base(caption, description, "common__barchart")
    {
        var xMin = -1;
        var xMax = details.Count() * 2;
        
        var yMin = -10;
        var yMax = 2;
        var yRange = yMax - yMin;

        ViewBox = $"{xMin} {yMin - 1} {xMax - xMin} {yRange}";

        var ordinates = details.Select(d => d.Count).Concat(axes.Select(Convert.ToDouble));
        var inf = ordinates.Min();
        var sup = ordinates.Max();

        var ratio = yMin / (sup - inf);

        foreach (var axis in axes)
        {
            var y = axis * ratio ;
            _drawings.Add(new(new Line(new(xMin, y), new(xMax, y), palette.SelectionOrDefault), "common__barchart__axis"));
            _drawings.Add(new(new Text(axis.ToString(), xMin, y + 1 * ratio, palette.Text), "common__barchart__ordinate"));
        }

        var index = 0.5;
        foreach (var detail in details)
        {
            _drawings.Add(new(
                new Rect(index, detail.Count * ratio, 1, -detail.Count * ratio, new(detail.Color, palette.Selection), true, detail.IsSelected),
                "common__barchart__detail",
                null,
                detail.Description,
                $"{detail.Title} : {detail.Count:0.##}{unit}"));

            _drawings.Add(new(new Text(detail.Title, index, yMax - 1.25, palette.Text), "common__barchart__abscissa"));

            index += 2;
        }
    }
}
