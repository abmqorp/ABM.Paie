namespace Common.Models;

public sealed record OperationModel(UriModel Uri, ActivatorModel Activator, Action? Action = default)
{
    public static implicit operator OperationModel(UriModel model) => new(model, new());
}
