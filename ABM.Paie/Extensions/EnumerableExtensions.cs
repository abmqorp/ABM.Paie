namespace ABM.Paie.Extensions;

public static class EnumerableExtensions
{
    public static List<T> ToRandomizedList<T>(this IEnumerable<T> source)
    {
        var list = source.ToList();
        var n = list.Count;
        var r = new Random();

        while (n-- > 1)
        {
            var k = r.Next(n + 1);
            (list[n], list[k]) = (list[k], list[n]);
        }

        return list;
    }
}
