namespace Common.Models;
public record NavModel(UriModel Uri, ActivatorModel Activator, Action? Action = null)
{
    public Action? Action { get; set; } = Action;

    public static implicit operator NavModel(UriModel model) => new(model, new());
}
