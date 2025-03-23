using SFML.System;
using Silver.Settings;

namespace Silver.Time;

internal class GameClock : Clock
{
    private float _totalTimeBeforeUpdate;
    private float _totalTimeElapsed;
    private float _previousTotalTimeElapsed;

    private readonly float _timeBeforeUpdate;

    public GameClock()
    {
        _timeBeforeUpdate = 1f / GameSettings.FPS;
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
