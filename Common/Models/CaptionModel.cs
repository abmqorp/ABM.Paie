using Common.Enumerations;

namespace Common.Models;

public record CaptionModel(string Text, Position Position = Position.Top);
