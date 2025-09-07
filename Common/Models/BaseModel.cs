namespace Common.Models;
public class BaseModel(string? cssClass = null)
{
    public string? Class { get; } = cssClass;
}
