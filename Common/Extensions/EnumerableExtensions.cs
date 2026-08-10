namespace Common.Extensions;

public static class EnumerableExtensions
{
    extension<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> items) where TKey : notnull
    {
        public Dictionary<TKey, TValue> ToSafeDictionary()
        {
            return items.GroupBy(a => a.Key).Select(g => g.Last()).ToDictionary();
        }
    }
}
