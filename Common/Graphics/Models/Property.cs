using Common.Extensions;
using Common.Graphics.Enumerations;
using Common.Graphics.Extensions;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Common.Graphics.Models;

public abstract class Property
{
    public enum Anchor
    {
        Start,
        Middle,
        End,
    }

    public enum LineCap
    {
        Butt,
        Square,
        Round,
    }

    public enum Unit
    {
        [Description("")]
        None,
        [Description("%")]
        Percent,
        [Description("px")]
        Px,
        [Description("rem")]
        Rem,
    }

    public sealed class D(string d) : Property
    {
        public static implicit operator D(string value) => new(value);

        public override string ToString() => d;
    }

    public sealed class Fill(Color color = default) : Property
    {
        public static implicit operator Fill(Color color) => new(color);
        public static implicit operator Fill?(Color? value) => value is Color color ? new(color) : null;
        public override string ToString() => color.Var;
    }

    public sealed class Stroke(Color? color = default) : Property
    {
        public static implicit operator Stroke(Color color) => new(color);
        public static implicit operator Stroke?(Color? value) => value is Color color ? new(color) : null;
        public override string ToString() => color?.Var ?? "none";
    }

    public sealed class StrokeLineCap(LineCap lineCap = default) : Property
    {
        public static implicit operator StrokeLineCap(LineCap lineCap) => new(lineCap);
        public static implicit operator StrokeLineCap?(LineCap? value) => value is LineCap lineCap ? new(lineCap) : null;
        public override string ToString() => lineCap.ToCamelCase();
    }

    public sealed class TextAnchor(Anchor anchor = default) : Property
    {
        public static implicit operator TextAnchor(Anchor anchor) => new(anchor);
        public static implicit operator TextAnchor?(Anchor? value) => value is Anchor anchor ? new(anchor) : null;

        public override KeyValuePair<string, object> ToAttribute() => ToAttribute("text-anchor");
        public override string ToString() => anchor.ToCamelCase();
    }

    public sealed class Transform : Property
    {
        private readonly List<string> _transforms = [];

        public override string ToString() => string.Join(' ', _transforms);

        public Transform Rotate(double rotate) => Add(GetString(rotate));
        public Transform Scale(double scale) => Add(GetString(scale));
        public Transform Translate(Point translate) => Add($"{nameof(translate)}{translate}");

        private Transform Add(string transform)
        {
            _transforms.Add(transform);
            return this;
        }

        private static string GetString(double value, [CallerArgumentExpression(nameof(value))] string name = "") => 
            name + "(" + value.Invariant + ")";
    }

    public abstract class Value(double value, Unit unit = default, string? name = null) : Property
    {
        public override KeyValuePair<string, object> ToAttribute() => ToAttribute(name);
        public override string ToString() => $"{value.Invariant}{unit.Description}";
    }

    public sealed class Cx(double value, Unit unit = default) : Value(value, unit);
    public sealed class Cy(double value, Unit unit = default) : Value(value, unit);
    public sealed class FontSize(double value, Unit unit = Unit.Rem) : Value(value, unit, "font-size");
    public sealed class Height(double value, Unit unit = Unit.Percent) : Value(value, unit);
    public sealed class Opacity(double value) : Value(value);
    public sealed class R(double value, Unit unit = default) : Value(value, unit);
    public sealed class Rx(double value, Unit unit = default) : Value(value, unit);
    public sealed class Ry(double value, Unit unit = default) : Value(value, unit);
    public sealed class StrokeWidth(double value, Unit unit = Unit.Rem) : Value(value, unit, "stroke-width");
    public sealed class Width(double value, Unit unit = Unit.Percent) : Value(value, unit);
    public sealed class X(double value, Unit unit = default) : Value(value, unit);
    public sealed class X1(double value, Unit unit = default) : Value(value, unit);
    public sealed class X2(double value, Unit unit = default) : Value(value, unit);
    public sealed class Y(double value, Unit unit = default) : Value(value, unit);
    public sealed class Y1(double value, Unit unit = default) : Value(value, unit);
    public sealed class Y2(double value, Unit unit = default) : Value(value, unit);

    public sealed class ViewBox(int x, int y, int width, int height) : Property
    {
        private static readonly ViewBox _icon = new(0, -960, 960, 960);
        public static ViewBox Icon => _icon;

        public override string ToString() => $"{x} {y} {width} {height}";
    }

    public virtual KeyValuePair<string, object> ToAttribute() => ToAttribute(null);
    public abstract override string ToString();

    protected KeyValuePair<string, object> ToAttribute(string? name) => new(name ?? GetType().Name.ToCamelCase(), ToString());
}
