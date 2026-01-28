using Common.Models;
using System.Collections.Immutable;

namespace ABM.Paie.Formation.Resources;

public static class Values
{
    public enum Key
    {
        Respect,
        Quality,
        Organization,
        Originality,
        Curiosity,
    }

    public static readonly ImmutableDictionary<Key, BarModel> Dictionary = ImmutableDictionary.CreateRange(new KeyValuePair<Key, BarModel>[]
    {
        new(Key.Respect, new("Respect", 3)),
        new(Key.Quality, new("Qualité", 1)),
        new(Key.Organization, new("Animation", 4)),
        new(Key.Originality, new("Originalité", 2)),
        new(Key.Curiosity, new("Curiosité", 5)),
    });
}
