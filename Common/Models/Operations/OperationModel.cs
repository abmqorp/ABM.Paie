using Common.Models.Uris;

namespace Common.Models.Operations;
public record OperationModel(UriModel Uri, ActivatorModel Activator, Action? Action = null)
{
    public static implicit operator OperationModel(UriModel model) => new(model, new());
}
