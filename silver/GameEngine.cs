using SFML.Window;
using Silver.Time;

namespace Silver;

internal class GameEngine
{
    private readonly GameWindow _window;
    private readonly GameClock _clock;

    public GameEngine()
    {
        _window = new GameWindow();
        _clock = new GameClock();
    }

    public void Run()
    {
        while (_window.IsOpen())
        {
            if (_clock.TryUpdate())
            {
                _window.DispatchEvents();
                _window.Update();

                _window.Clear();
                _window.Draw();
                _window.Display();

                _clock.Restart();
            }
        }
    }
}
