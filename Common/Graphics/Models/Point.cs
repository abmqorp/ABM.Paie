using Common.Extensions;

namespace Common.Graphics.Models;

public class Point(double X, double Y)
{
    public double X { get; set; } = X;
    public double Y { get; set; } = Y;

    public static Point Polar(double radius, double percentage)
    {
        double coordinate(Func<double, double> function) => radius * function.Invoke(2 * Math.PI * percentage / 100);
        return new(coordinate(Math.Cos), coordinate(Math.Sin));
    }

    public override string ToString() => $"({X.Invariant}, {Y.Invariant})";
}
