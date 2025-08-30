using SFML.System;
using Engine.Settings;

namespace Engine.Time;

internal class GameClock : Clock
{
    private float _totalTimeBeforeUpdate;
    private float _totalTimeElapsed;
    private float _previousTotalTimeElapsed;

    private readonly float _timeBeforeUpdate;

    public GameClock(ExternalSettings externalSettings)
    {
        _timeBeforeUpdate = 1f / externalSettings.FPS;
    }

    public bool TryUpdate()
    {
        _totalTimeElapsed = ElapsedTime.AsSeconds();

        float deltaTime = _totalTimeElapsed - _previousTotalTimeElapsed;
        _previousTotalTimeElapsed = _totalTimeElapsed;

        _totalTimeBeforeUpdate += deltaTime;

        return _totalTimeBeforeUpdate >= _timeBeforeUpdate;
    }

    public new void Restart()
    {
        _totalTimeBeforeUpdate = 0f;
    }
}
