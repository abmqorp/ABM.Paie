namespace Common.Models.General;

public sealed record Vector(double X, double Y)
{
    public static Vector Zeros => new(0, 0);
    public static Vector Ones => new(1, 1);

    public double X { get; set; } = X;
    public double Y { get; set; } = Y;

    public static Vector Polar(double radius, double percentage)
    {
        double coordinate(Func<double, double> function) => radius * function.Invoke(2 * Math.PI * percentage / 100);
        return new(coordinate(Math.Cos), coordinate(Math.Sin));
    }
}
