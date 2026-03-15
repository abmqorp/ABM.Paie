using Common.Extensions;
using Common.Models;
using Common.Models.General;
using Common.Models.Svg;

namespace Common.Tools.Builders;

public record PathBuilder(Palette Palette, bool IsFocusable = default, bool IsSelected = default, double Multiplier = 1)
    : Shape(Palette, IsFocusable, IsSelected, Multiplier: Multiplier)
{
    private abstract record Path(double Multiplier)
    {
        public double Multiplier { get; set; } = Multiplier;
        protected string Compute(double value) => (value / Multiplier).Invariant;
    }

    private sealed record APath(Vector Radius, bool LargeArcFlag, Vector End, double Multiplier) : Path(Multiplier)
    {
        public override string ToString()
            => $"A {Compute(Radius.X)} {Compute(Radius.Y)} 0 {(LargeArcFlag ? 1 : 0)} 1 {Compute(End.X)} {Compute(End.Y)}";
    }

    private sealed record LPath(Vector Start, double Multiplier) : Path(Multiplier)
    {
        public override string ToString() => $"L {Compute(Start.X)} {Compute(Start.Y)}";
    }

    private sealed record MPath(Vector Start, double Multiplier) : Path(Multiplier)
    {
        public override string ToString() => $"M {Compute(Start.X)} {Compute(Start.Y)}";
    }

    private sealed record ZPath() : Path(0)
    {
        public override string ToString() => "Z";
    }

    private const char Sep = ' ';

    private readonly List<Path> _paths= [];

    public override IEnumerable<KeyValuePair<string, object>> Attributes => [new(nameof(Models.Svg.Path.D).ToLower(), string.Join(Sep, _paths))];
    private double PathMultiplier => IsSelected ? 1 : Multiplier;

    public override void Toggle()
    {
        base.Toggle();
        _paths.ForEach(p => p.Multiplier = PathMultiplier);
    }

    public PathBuilder Arc(Vector radius, bool largeArcFlag, Vector end)
    {
        _paths.Add(new APath(radius, largeArcFlag, end, PathMultiplier));
        return this;
    }

    public PathBuilder Close()
    {
        _paths.Add(new ZPath());
        return this;
    }

    public PathBuilder Move(Vector point)
    {
        _paths.Add(new MPath(point, PathMultiplier));
        return this;
    }

    public PathBuilder Line(Vector point)
    {
        _paths.Add(new LPath(point, PathMultiplier));
        return this;
    }
}
