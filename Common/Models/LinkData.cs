using Common.Enumerations;

namespace Common.Models;
public record LinkData(
    string Url,
    string Text,
    bool IsExternal = false,
    IconPath? StartIcon = null,
    IconPath? EndIcon = null,
    string? Class = null)
{ }
