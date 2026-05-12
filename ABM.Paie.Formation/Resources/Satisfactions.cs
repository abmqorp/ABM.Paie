using ABM.Paie.Formation.Models;
using System.Collections.Immutable;

namespace ABM.Paie.Formation.Resources;

public static class Satisfactions
{
    public static readonly ImmutableDictionary<int, SatisfactionModel?> Dictionary = ImmutableDictionary.CreateRange(new KeyValuePair<int, SatisfactionModel?>[]
    {
        new(2026, null),
        new(2025, new(0.95, new(2026, 04, 01), 2, 51, 10)),
        new(2024, new(0.85, new(2025, 04, 01), 1, 15, 6)),
    });

    public static KeyValuePair<int, SatisfactionModel?> Last => GetAll().FirstOrDefault();
    public static KeyValuePair<int, SatisfactionModel?> Latest => GetAll().FirstOrDefault(s => s.Value is not null);
    public static IEnumerable<KeyValuePair<int, SatisfactionModel?>> Archive => GetAll().Skip(1);
    private static IEnumerable<KeyValuePair<int, SatisfactionModel?>> GetAll() => Dictionary.OrderByDescending(s => s.Key);
}
