namespace Common.Models.General;

public sealed record Reference(UriModel? Attribution = null, UriModel? Licence = null)
{
    public bool IsEmpty => Attribution is null && Licence is null;
}
