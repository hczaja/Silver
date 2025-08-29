using SFML.System;
using System.Drawing;

namespace Core.Time;

public class Timer : Clock
{
    private float RealTime { get; set; }
    private bool IsRunning { get; set; }

    public Timer()
    {
        Start();
    }

    public float Elapsed() => RealTime;

    public void Update()
    {
        if (IsRunning)
            RealTime = ElapsedTime.AsSeconds();
    }

    public void Stop() => IsRunning = false;

    public void Start() => IsRunning = true;

    public new void Restart()
    {
        base.Restart();
        RealTime = 0f;
    }

}
