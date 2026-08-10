namespace Common.Graphics.Svg.Models;

public abstract class Builder : Shape
{

    private readonly List<Shape> _shapes = [];
    public IEnumerable<Shape> Shapes => _shapes;

    public Builder Add(Shape shape)
    {
        _shapes.Add(shape);
        return this;
    }

    public Builder AddRange(IEnumerable<Shape> shapes)
    {
        _shapes.AddRange(shapes);
        return this;
    }
}
