using Common.Models.Bases;

namespace Common.Models.Charts;

public sealed record BarModel(string Title, int Percent, string? Description = null, bool IsSelected = false) : SelectableModel(IsSelected);
