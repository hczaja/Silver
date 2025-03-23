using SFML.Graphics;
using Silver.Settings;

namespace Silver;

internal class GameWindow
{
    private readonly GameCore _core;
    private readonly RenderWindow _window;

    public GameWindow(GameCore core)
    {
        _core = core;
        _window = new RenderWindow(
            VideoStandard.WXGA.Mode,
            GameSettings.Title);

        _window.SetKeyRepeatEnabled(enable: GameSettings.EnableKeyRepeat);

        _window.Closed += (_, _) => Close();

        _window.KeyPressed += _core.KeyPressed;
        _window.KeyReleased += _core.KeyReleased;
        _window.MouseButtonPressed += _core.MouseButtonPressed;
        _window.MouseButtonReleased += _core.MouseButtonReleased;
    }

    public void Clear() => _window.Clear();

    public void DispatchEvents() => _window.DispatchEvents();

    public void Display() => _window.Display();

    public void Draw() { } // _core.Render(_window);

    public bool IsOpen() => _window.IsOpen;

    public void Update() { } // => _core.Update();

    private void Close() => _window.Close();
}
