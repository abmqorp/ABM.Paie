using Timer = System.Timers.Timer;

namespace Common.Extensions;

public static class TimerExtensions
{
    extension(Timer timer)
    {
        public void Reset()
        {
            timer.Stop();
            timer.Start();
        }
    }
}
