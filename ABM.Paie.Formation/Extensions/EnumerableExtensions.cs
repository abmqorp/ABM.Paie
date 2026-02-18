namespace ABM.Paie.Formation.Extensions;

public static class EnumerableExtensions
{
    extension<T>(IEnumerable<T> source)
    {
        public List<T> Randomized
        {
            get
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
    }
}
