namespace Common.Models;
public class NavModel(UriModel uri, ActivatorModel activator, Action? action = null)
{
    public UriModel Uri { get; set; } = uri;
    public ActivatorModel Activator { get; set; } = activator;
    public Action? Action { get; set; } = action;

    public static implicit operator NavModel(UriModel data) => new(data, new());
}
