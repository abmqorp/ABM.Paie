using Common.Enumerations;

namespace Common.Models;

public sealed record ImageModel(string Source, string Label, double? Scale = null, SizeProperty Property = default);
