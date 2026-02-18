namespace Common.Models.General;

public sealed record Point(double X, double Y)
{
    public double X { get; set; } = X;
    public double Y { get; set; } = Y;

    public static Point Polar(double radius, double percent)
    {
        double coordinate(Func<double, double> function) => radius * function.Invoke(2 * Math.PI * percent / 100);
        return new(coordinate(Math.Cos), coordinate(Math.Sin));
    }
}
