namespace Common.Models.Charts;

public sealed record PieModel
{
    private readonly List<SliceModel> _slices = [];
    public IEnumerable<SliceModel> Slices => _slices; 

    public PieModel(IEnumerable<BarModel> bars)
    {
        var total = bars.Select(b => b.Count).Sum();
        var cumSum = 0d;
        foreach (var bar in bars)
        {
            _slices.Add(new(bar, total, cumSum));
            cumSum += bar.Count;
        }
    }
}
