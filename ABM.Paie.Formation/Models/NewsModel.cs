using ABM.Paie.Formation.Enumerations;

namespace ABM.Paie.Formation.Models;
public sealed record NewsModel(string Title, AbmUri Uri, string? Description = default);
