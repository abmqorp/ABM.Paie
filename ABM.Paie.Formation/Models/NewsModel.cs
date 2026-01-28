using Common.Models;

namespace ABM.Paie.Formation.Models;

public sealed record NewsModel(string Title, UriModel Uri, IEnumerable<string>? Descriptions = default);
