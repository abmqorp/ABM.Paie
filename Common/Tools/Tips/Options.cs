namespace Common.Tools.Tips;

public sealed class Options
{
    public TimeSpan ShowDelay { get; set; } = TimeSpan.FromMilliseconds(300);
    public TimeSpan HideDelay { get; set; } = TimeSpan.FromMilliseconds(100);
}
