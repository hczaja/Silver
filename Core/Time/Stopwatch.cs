using SFML.System;

namespace Core.Time;

internal class Stopwatch : Clock
{
    private float InitialTime { get; set; }
    private float RealTime { get; set; }

    public Stopwatch(float initialTime)
        => InitialTime = initialTime;

    public bool Update()
    {
        RealTime = InitialTime - ElapsedTime.AsSeconds();
        return RealTime > 0f;
    }

    public new void Restart()
    {
        base.Restart();
        RealTime = InitialTime;
    }
}
